using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Data;
using server.DTOs;
using server.Entity;
using server.Entity.OrderAggregate;
using server.Extensions;

namespace server.Controller
{
    public class OrderController(StoreContext _context) : BaseController
    {
        [Authorize]

        [HttpGet]
        public async Task<ActionResult<List<OrderDto>>> GetOrders()
        {
            return await _context.Orders.MapOrderToOrderDto(User.Identity.Name).ToListAsync();
        }
        [HttpGet("{id}", Name = "GetOrder")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            return await _context.Orders.Include(o => o.OrderItems).Where(x => x.BuyerId == User.Identity.Name && x.Id == id).FirstOrDefaultAsync();
        }
        [HttpPost]
        public async Task<ActionResult<string>> CreateOrder(CreateOrderDto createOrderDto)
        {
            var cart = await _context.Carts.RetrieveCartWithItems(User.Identity.Name).FirstOrDefaultAsync();
            if (cart == null) return BadRequest(new ProblemDetails { Title = "Cart not found." });
            var items = new List<OrderItem>();
            foreach (var item in cart.Items)
            {
                var productItems = await _context.Products.FindAsync(item.Id);
                var itemOrdered = new ProductItemOrdered
                {
                    ProductId = productItems.Id,
                    Name = productItems.Name,
                    Thumbnail = productItems.Thumbnail,
                };
                var orderItem = new OrderItem
                {
                    ItemOrdered = itemOrdered,
                    Price = productItems.Price,
                    Quantity = item.Quantity,
                };
                items.Add(orderItem);
                productItems.QuantityInStock -= item.Quantity;
            }
            var subTotal = items.Sum(item => item.Price * item.Quantity);
            var deliveryFee = subTotal > 10000 ? 0 : 1000;
            var order = new Order
            {
                BuyerId = User.Identity.Name,
                ShippingAddress = createOrderDto.ShippingAddress,
                OrderItems = items,
                SubTotal = subTotal,
                DeliveryFee = deliveryFee,
            };
            _context.Orders.Add(order);
            _context.Carts.Remove(cart);
            if (createOrderDto.SaveAddress)
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == User.Identity.Name);
                if (user != null)
                {
                    user.Address = new UserAddress
                    {
                        FullName = createOrderDto.ShippingAddress.FullName,
                        Address1 = createOrderDto.ShippingAddress.Address1,
                        Address2 = createOrderDto.ShippingAddress.Address2 ?? createOrderDto.ShippingAddress.Address2,
                        City = createOrderDto.ShippingAddress.City,
                        State = createOrderDto.ShippingAddress.State,
                        PostCode = createOrderDto.ShippingAddress.PostCode,
                        Country = createOrderDto.ShippingAddress.Country,
                    };
                    _context.Update(user);
                }
            }
            var result = await _context.SaveChangesAsync() > 0;
            if (result) return CreatedAtRoute("GetOrder", new { id = order.Id }, "Order Created Succssfully.");
            return BadRequest("Problem while creating order.");
        }
    }
}
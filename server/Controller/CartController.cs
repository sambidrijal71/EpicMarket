using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Data;
using server.DTOs;
using server.Entity;

namespace server.Controller
{
    public class CartController(StoreContext _context) : BaseController
    {
        [HttpGet(Name = "getCart")]
        public async Task<ActionResult<CartDto>> GetCartItems()
        {
            var cart = await RetrieveCart();
            if (cart == null) return BadRequest(new ProblemDetails { Title = "Cart not Found." });
            return CreatedAtRoute("GetCart", MapCartItemsToDto(cart));
        }

        [HttpPost("addCartItems")]
        public async Task<ActionResult<CartDto>> AddItemsToCart(int productId, int quantity)
        {
            var cart = await RetrieveCart() ?? CreateCart();
            var product = await _context.Products.FindAsync(productId);
            if (product == null) return BadRequest();
            cart.AddItem(product, quantity);
            var result = await _context.SaveChangesAsync() > 0;
            if (result) return CreatedAtRoute("GetCart", MapCartItemsToDto(cart));
            return BadRequest(result);
        }

        [HttpDelete("removeCartItems")]
        public async Task<ActionResult<CartDto>> RemoveItemsFromCart(int productId, int quantity)
        {
            var cart = await RetrieveCart();
            if (cart == null) return BadRequest();
            var product = await _context.Products.FindAsync(productId);
            cart.RemoveItem(product.Id, quantity);
            var result = await _context.SaveChangesAsync() > 0;
            if (!result) return BadRequest(result);
            return CreatedAtRoute("GetCart", MapCartItemsToDto(cart));
        }
        private async Task<Cart> RetrieveCart()
        {
            return await _context.Carts.Include(i => i.Items).ThenInclude(p => p.Product).FirstOrDefaultAsync(b => b.BuyerId == Request.Cookies["buyerId"]) ?? null;
        }

        private Cart CreateCart()
        {
            var buyerId = Guid.NewGuid().ToString();
            var cookieOptions = new CookieOptions
            {
                IsEssential = true,
                Expires = DateTime.UtcNow.AddDays(7)
            };
            Response.Cookies.Append("buyerId", buyerId, cookieOptions);
            var cart = new Cart { BuyerId = buyerId };
            _context.Carts.Add(cart);
            return cart;
        }

        private static CartDto MapCartItemsToDto(Cart cart)
        {
            return new CartDto
            {
                Id = cart.Id,
                BuyerId = cart.BuyerId,
                Items = cart.Items.Select(d => new CartItemDto
                {
                    Id = d.Product.Id,
                    Name = d.Product.Name,
                    Description = d.Product.Description,
                    Category = d.Product.Description,
                    Brand = d.Product.Description,
                    Tags = d.Product.Tags,
                    Price = d.Product.Price,
                    QuantityInStock = d.Product.QuantityInStock,
                    DiscountPercentage = d.Product.DiscountPercentage,
                    Rating = d.Product.Rating,
                    WarrantyInformation = d.Product.WarrantyInformation,
                    ShippingInformation = d.Product.ShippingInformation,
                    AvailabilityStatus = d.Product.AvailabilityStatus,
                    ReturnPolicy = d.Product.ReturnPolicy,
                    Images = d.Product.Images,
                    Thumbnail = d.Product.Thumbnail,
                    Quantity = d.Quantity,
                }).ToList()
            };
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Data;
using server.DTOs;
using server.Entity;
using server.Extensions;

namespace server.Controller
{
    public class CartController(StoreContext _context) : BaseController
    {
        [HttpGet(Name = "getCart")]
        public async Task<ActionResult<CartDto>> GetCartItems()
        {
            var cart = await RetrieveCart(GetBuyerId());
            if (cart == null) return BadRequest(new ProblemDetails { Title = "Cart not Found." });
            return CreatedAtRoute("GetCart", cart.MapCartToDto());
        }

        [HttpPost("addCartItems")]
        public async Task<ActionResult<CartDto>> AddItemsToCart(int productId, int quantity)
        {
            var cart = await RetrieveCart(GetBuyerId()) ?? CreateCart();
            var product = await _context.Products.FindAsync(productId);
            if (product == null) return BadRequest();
            cart.AddItem(product, quantity);
            var result = await _context.SaveChangesAsync() > 0;
            if (result) return CreatedAtRoute("GetCart", cart.MapCartToDto());
            return BadRequest(result);
        }

        [HttpDelete("removeCartItems")]
        public async Task<ActionResult<CartDto>> RemoveItemsFromCart(int productId, int quantity)
        {
            var cart = await RetrieveCart(GetBuyerId());
            if (cart == null) return BadRequest();
            var product = await _context.Products.FindAsync(productId);
            cart.RemoveItem(product.Id, quantity);
            var result = await _context.SaveChangesAsync() > 0;
            if (!result) return BadRequest(result);
            return CreatedAtRoute("GetCart", cart.MapCartToDto());
        }
        private async Task<Cart> RetrieveCart(string buyerId)
        {
            if (string.IsNullOrEmpty(buyerId))
            {
                Response.Cookies.Delete("buyerId");
                return null;
            }
            return await _context.Carts.Include(i => i.Items).ThenInclude(p => p.Product).FirstOrDefaultAsync(b => b.BuyerId == buyerId);
        }
        private string GetBuyerId()
        {
            return User.Identity?.Name ?? Request.Cookies["buyerId"];
        }
        private Cart CreateCart()
        {
            var buyerId = User.Identity?.Name;
            if (string.IsNullOrEmpty(buyerId))
            {
                buyerId = Guid.NewGuid().ToString();
                var cookieOptions = new CookieOptions
                {
                    IsEssential = true,
                    Expires = DateTime.UtcNow.AddDays(7)
                };
                Response.Cookies.Append("buyerId", buyerId, cookieOptions);
            }

            var cart = new Cart { BuyerId = buyerId };
            _context.Carts.Add(cart);
            return cart;
        }
    }
}
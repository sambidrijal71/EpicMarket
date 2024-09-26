using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Entity;

namespace server.Controller
{
    public class CartController(StoreContext _context) : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<Cart>> GetCart()
        {
            var cart = await RetrieveCart();
            if (cart == null) return BadRequest(new ProblemDetails { Title = "Cart not Found." });
            return Ok(cart);
        }

        [HttpPost]
        public async Task<ActionResult<Cart>> AddItemsToCart(int productId, int quantity)
        {
            var cart = await RetrieveCart() ?? CreateCart();
            var product = await _context.Products.FindAsync(productId);
            if (product == null) return BadRequest();
            cart.AddItem(product, quantity);
            var result = await _context.SaveChangesAsync() > 0;
            if (result) return Ok(cart);
            return BadRequest(result);
        }
        public async Task<Cart> RetrieveCart()
        {
            return await _context.Carts.FirstOrDefaultAsync(b => b.BuyerId == Request.Cookies["buyerId"]) ?? null;
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
    }
}
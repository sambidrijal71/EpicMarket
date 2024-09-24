using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Entity;

namespace server.Controller
{
    public class ProductsController(StoreContext _context) : BaseController
    {
        [HttpGet(Name = "GetProducts")]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            if (products == null) return BadRequest(new ProblemDetails { Title = "Products not found in the database." });
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return BadRequest(new ProblemDetails { Title = $"Product with id {id} not found in the database." });
            return Ok(product);
        }
    }
}
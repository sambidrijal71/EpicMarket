using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Entity;
using server.Extensions;
using server.RequestHelpers;

namespace server.Controller
{
    public class ProductsController(StoreContext _context) : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts([FromQuery] ProductParams productParams)
        {
            var query = _context.Products.Sort(productParams.OrderBy).Search(productParams.SearchTerm).Filter(productParams.Brands, productParams.Categories).AsQueryable();
            var products = await PagedList<Product>.ToPagedList(query, productParams.PageNumber, productParams.PageSize);
            Response.AddPaginationToHeader(products.MetaData);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return BadRequest(new ProblemDetails { Title = $"Product with id {id} not found in the database." });
            return Ok(product);
        }

        [HttpGet("filter")]
        public async Task<ActionResult<List<string>>> GetFilters()
        {
            var brands = await _context.Products.Select(p => p.Brand).Distinct().ToListAsync();
            var categories = await _context.Products.Select(p => p.Category).Distinct().ToListAsync();
            return Ok(new { brands, categories });
        }
    }
}
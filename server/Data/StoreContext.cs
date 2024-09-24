using Microsoft.EntityFrameworkCore;
using server.Entity;

namespace server.Data
{
    public class StoreContext(DbContextOptions option) : DbContext(option)
    {
        public DbSet<Product> Products { get; set; }
    }
}
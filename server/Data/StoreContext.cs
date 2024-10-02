using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using server.Entity;

namespace server.Data
{
    public class StoreContext(DbContextOptions option) : IdentityDbContext<User>(option)
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "member", NormalizedName = "MEMBER" },
                new IdentityRole { Name = "admin", NormalizedName = "ADMIN" }
            );
        }
    }

}
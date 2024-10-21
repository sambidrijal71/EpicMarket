using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using server.Entity;
using server.Entity.OrderAggregate;

namespace server.Data
{
    public class StoreContext(DbContextOptions option) : IdentityDbContext<User, Role, int>(option)
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().HasOne(a => a.Address).WithOne().HasForeignKey<UserAddress>(a => a.Id).OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "member", NormalizedName = "MEMBER" },
                new Role { Id = 2, Name = "admin", NormalizedName = "ADMIN" }
            );
        }
    }

}
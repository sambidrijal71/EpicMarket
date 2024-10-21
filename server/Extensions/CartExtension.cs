using Microsoft.EntityFrameworkCore;
using server.DTOs;
using server.Entity;

namespace server.Extensions
{
    public static class CartExtension
    {
        public static CartDto MapCartToDto(this Cart cart)
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
        public static IQueryable<Cart> RetrieveCartWithItems(this IQueryable<Cart> query, string buyerId)
        {

            return query.Include(c => c.Items).ThenInclude(p => p.Product).Where(b => b.BuyerId == buyerId);
        }
    }
}
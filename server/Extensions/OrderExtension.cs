using Microsoft.EntityFrameworkCore;
using server.DTOs;
using server.Entity.OrderAggregate;

namespace server.Extensions
{
    public static class OrderExtension
    {
        public static IQueryable<OrderDto> MapOrderToOrderDto(this IQueryable<Order> query, string buyerId)
        {
            return query.Select(order => new OrderDto
            {
                Id = order.Id,
                BuyerId = order.BuyerId,
                OrderDate = order.OrderDate,
                ShippingAddress = order.ShippingAddress,
                DeliveryFee = order.DeliveryFee,
                SubTotal = order.SubTotal,
                OrderStatus = order.OrderStatus.ToString(),
                Total = order.GetTotal(),
                OrderItems = order.OrderItems.Select(x => new OrderItemDto
                {
                    ProductId = x.ItemOrdered.ProductId,
                    Name = x.ItemOrdered.Name,
                    Thumbnail = x.ItemOrdered.Thumbnail,
                    Price = x.Price,
                    Quantity = x.Quantity

                }).ToList()
            }).AsNoTracking();
        }
    }
}
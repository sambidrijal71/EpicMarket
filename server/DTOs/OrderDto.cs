using server.Entity.OrderAggregate;

namespace server.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string BuyerId { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
        public long SubTotal { get; set; }
        public long DeliveryFee { get; set; }
        public long Total { get; set; }
        public string OrderStatus { get; set; }
    }
}
using server.Entity;

namespace server.DTOs
{
    public class CartDto
    {
        public int Id { get; set; }
        public string BuyerId { get; set; }
        public List<CartItemDto> Items { get; set; }
    }
}
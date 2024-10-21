namespace server.DTOs
{
    public class OrderItemDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Thumbnail { get; set; }
        public long Price { get; set; }
        public int Quantity { get; set; }
    }
}
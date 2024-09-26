using server.Entity;

namespace server.DTOs
{
    public class CartItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public double DiscountPercentage { get; set; }
        public double Rating { get; set; }
        public int QuantityInStock { get; set; }
        public List<string> Tags { get; set; }
        public string Brand { get; set; }
        public string WarrantyInformation { get; set; }
        public string ShippingInformation { get; set; }
        public string AvailabilityStatus { get; set; }
        public string ReturnPolicy { get; set; }
        public List<string> Images { get; set; }
        public string Thumbnail { get; set; }
        public int Quantity { get; set; }
    }
}
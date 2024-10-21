using Microsoft.EntityFrameworkCore;

namespace server.Entity.OrderAggregate
{
    [Owned]
    public class ProductItemOrdered
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Thumbnail { get; set; }
    }
}
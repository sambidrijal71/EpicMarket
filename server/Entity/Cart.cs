namespace server.Entity
{
    public class Cart
    {
        public int Id { get; set; }
        public string BuyerId { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();


        public void AddItem(Product product, int quantity)
        {
            if (Items.TrueForAll(x => x.ProductId != product.Id))
            {
                Items.Add(new CartItem
                {
                    Product = product,
                    Quantity = quantity

                });
                return;
            }
            var item = Items.Find(x => x.ProductId == product.Id);
            if (item == null)
            {
                return;
            }
            item.Quantity += quantity;

        }

        public void RemoveItem(int productId, int quantity)
        {
            var item = Items.Find(x => x.ProductId == productId);
            if (item == null) return;
            item.Quantity -= quantity;
            if (item.Quantity <= 0)
            {
                Items.Remove(item);
            }
        }
    }
}
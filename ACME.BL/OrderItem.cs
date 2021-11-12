namespace ACME.BL
{
    public class OrderItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public bool Validate()
        {
            return true;
        }
        public bool Retrieve()
        {
            return true;
        }
        public bool Save()
        {
            return true;
        }

    }
}
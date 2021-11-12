namespace ACME.BL
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }

        public int InstantCount { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                var fullName = FirstName;
                if (string.IsNullOrWhiteSpace(LastName)) return fullName;
                if (!string.IsNullOrWhiteSpace(fullName)) fullName += ", ";
                fullName += LastName;
                return fullName;
            }
        }
        public bool Validate()
        {
            return (!string.IsNullOrWhiteSpace(EmailAddress) && !string.IsNullOrWhiteSpace(LastName));
        }

    }

    public class Product
    {
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public Product()
        {
            
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public bool Validate()
        {
            return (!string.IsNullOrWhiteSpace(ProductName) && CurrentPrice!=null);
        }
        public Product Retrieve()
        {
            return new Product();
        }
        public bool Save()
        {
            return true;
        }

    }
}
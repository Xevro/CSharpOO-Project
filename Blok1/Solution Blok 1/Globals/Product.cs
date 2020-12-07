using System;

namespace Globals
{
    public class Product : IComparable<Product>
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }

        private int productQuantity;
        public int ProductQuantity
        {
            get { return productQuantity; }
            set
            {
                if (value.GetType() == typeof(int)) productQuantity = value;
                else throw new FormatException($"{nameof(value)} must be a number");
            }
        }
        public ProductStatus ProductStatus { get; set; }

        public Product(string code, string name, int quantity, ProductStatus status)
        {
            ProductCode = code;
            ProductName = name;
            ProductQuantity = quantity;
            ProductStatus = status;
        }

        public override string ToString()
        {
            return $"Prduct code: {ProductCode}, Product name: {ProductName}, Quantity: {ProductQuantity}.";
        }

        public int CompareTo(Product other)
        {
            return this.ProductCode.CompareTo(other.ProductCode);
        }
    }
}

using System;

namespace Globals
{
    public class Product : IEquatable<Product>
    {
        private int productCode;
        public int ProductCode
        {
            get { return productCode; }
            set
            {
                if (value.GetType() == typeof(int)) productCode = value;
                else throw new FormatException($"{nameof(value)} must be a number");
            }
        }
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

        public Product(int code, string name, int quantity)
        {
            ProductCode = code;
            ProductName = name;
            ProductQuantity = quantity;
            if (quantity <= 0)
            {
                ProductStatus = ProductStatus.Outofstock;
            }
            else
            {
                ProductStatus = ProductStatus.Instock;
            }
        }
        public override string ToString()
        {
            return $"Prduct code: {ProductCode}, Product name: {ProductName}, Quantity: {ProductQuantity}.";
        }

        public bool Equals(Product other)
        {
            return other.productCode == this.productCode;
        }
    }
}

using System;

namespace Globals
{
    public class Product : IEquatable<Product>
    {
        public int ProductCode { get; set; }
        public string ProductName { get; set; }

        //private int productQuantity;
        public int ProductQuantity { get; set; }

        /* {
             get { return productQuantity; }
             set
             {
                 if (value >= 1) productQuantity = value;
                 else throw new ArgumentOutOfRangeException($"{value} must be at least 1");
             }
         }*/
        public ProductStatus ProductStatus { get; set; }

        public Product(int code, string name, int quantity)
        {
            ProductCode = code;
            ProductName = name;
            ProductQuantity = quantity;
            ProductStatus = (quantity <= 0) ? ProductStatus.Outofstock : ProductStatus.Instock;
        }
        public override string ToString()
        {
            return $"Prduct code: {ProductCode}, Product name: {ProductName}, Quantity: {ProductQuantity}.";
        }

        public bool Equals(Product other)
        {
            return other.ProductCode == this.ProductCode;
        }
    }
}

using System;

namespace Globals
{
    public class Product
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
        public Status ProductStatus { get; set; }

        public Product(string code, string name, int quantity, Status status)
        {
            ProductCode = code;
            ProductName = name;
            ProductQuantity = quantity;
            ProductStatus = status;
        }
    }
}

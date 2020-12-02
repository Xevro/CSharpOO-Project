using System;
using System.ComponentModel;

namespace Globals
{
    public class Item
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
                else throw new ArgumentOutOfRangeException($"{nameof(value)} must be a number");
            }
        }

        private string productStatus;
        public string ProductStatus
        {
            get { return productStatus; }
            set
            {
                if (Enum.IsDefined(typeof(Status), value)) productStatus = value;
                else throw new InvalidEnumArgumentException($"{nameof(value)} must be a selected choice");
            }
        }

        public Item(string code, string name, int quantity, string status)
        {
            ProductCode = code;
            ProductName = name;
            ProductQuantity = quantity;
            ProductStatus = status;
        }
    }
}

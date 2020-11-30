using System;

namespace Globals
{
    public class Item
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }

        public Item(string productCode, string productName, int quantity, string status)
        {
            ProductCode = productCode;
            ProductName = productName;
            Quantity = quantity;
            Status = status;
        }

        
    }
}

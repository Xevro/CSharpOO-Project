using System;

namespace Globals
{
    public class Order
    {
        public int OrderCode { get; set; }
        public string OrderName { get; set; }

        private int orderQuantity;
        public int OrderQuantity
        {
            get { return orderQuantity; }
            set
            {
                if (value.GetType() == typeof(int)) orderQuantity = value;
                else throw new FormatException($"{nameof(value)} must be a number");
            }
        }
        public OrderStatus OrderStatus { get; set; }

        public Order(int code, string name, int quantity, OrderStatus status)
        {
            OrderCode = code;
            OrderName = name;
            OrderQuantity = quantity;
            OrderStatus = status;
        }
    }
}

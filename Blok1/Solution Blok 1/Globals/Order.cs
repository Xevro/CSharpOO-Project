using System;
using System.Threading;

namespace Globals
{
    public class Order
    {
        public int OrderCode { get; set; }
        public int OrderProductCode { get; set; }
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
        private static int lastId = 0;

        public Order(int orderProductCode, string name, int quantity, OrderStatus status)
        {
            //OrderCode = orderCode;
            this.OrderCode = Interlocked.Increment(ref lastId);
            OrderProductCode = orderProductCode;
            OrderName = name;
            OrderQuantity = quantity;
            OrderStatus = status;
        }

        /*public Order(int code, string name, int quantity)
        {
            OrderCode = code;
            OrderName = name;
            OrderQuantity = quantity;
        }*/
    }
}

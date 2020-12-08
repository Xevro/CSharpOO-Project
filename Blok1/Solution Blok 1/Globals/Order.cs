using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace Globals
{
    public class Order : IEquatable<Order>
    {
        private int orderCode;
        public int OrderCode { get { return orderCode; } set { orderCode = value; } }

        private int orderProductCode;
        public int OrderProductCode { get { return orderProductCode; } set { orderProductCode = value; } }

        private string orderName;

        public string OrderName { get { return orderName; } set { orderName = value; } }

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
            this.OrderCode = Interlocked.Increment(ref lastId);
            OrderProductCode = orderProductCode;
            OrderName = name;
            OrderQuantity = quantity;
            OrderStatus = status;
        }

        public bool Equals(Order other)
        {
            return other.orderCode == this.orderCode;
        }
    }
}

using System;
using System.Threading;

namespace Globals
{
    public class Order : IEquatable<Order>
    {
        public int OrderCode { get; set; }
        public int OrderProductCode { get; set; }
        public string OrderName { get; set; }
        public int OrderQuantity { get; set; }
        public OrderStatus OrderStatus { get; set; }

        private static int lastId = 0;

        public Order(int orderProductCode, string name, int quantity, OrderStatus status)
        {
            OrderCode = Interlocked.Increment(ref lastId);
            OrderProductCode = orderProductCode;
            OrderName = name;
            OrderQuantity = quantity;
            OrderStatus = status;
        }

        public bool Equals(Order other)
        {
            return other.OrderCode == this.OrderCode;
        }
    }
}

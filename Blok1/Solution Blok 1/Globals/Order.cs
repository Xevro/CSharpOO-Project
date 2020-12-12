using System;

namespace Globals
{
    public struct Order : IEquatable<Order>
    {
        public int OrderCode { get; private set; }
        public int OrderProductCode { get; set; }
        public string OrderName { get; set; }
        public int OrderQuantity { get; set; }
        public OrderStatus OrderStatus { get; set; }

        private static int lastId = 0;

        public Order(int orderProductCode, string name, int quantity, OrderStatus status)
        {
            OrderCode = ++lastId;
            OrderProductCode = orderProductCode;
            OrderName = name;
            OrderQuantity = quantity;
            OrderStatus = status;
        }

        public Order(int orderID, int orderProductCode, string name, int quantity, OrderStatus status)
        {
            OrderCode = orderID;
            OrderProductCode = orderProductCode;
            OrderName = name;
            OrderQuantity = quantity;
            OrderStatus = status;
        }

        public bool Equals(Order other)
        {
            return other.OrderCode == this.OrderCode;
        }

        public Order Shallowcopy()
        {
            return (Order)this.MemberwiseClone();
        }
    }
}
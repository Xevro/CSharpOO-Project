using System;

namespace Globals
{
    public class HistoryOrder : IHistory
    {
        public DateTime DateDelivered { get; set; }
        public Order Order { get; set; }

        public HistoryOrder(Order order, DateTime date)
        {
            this.Order = order;
            this.DateDelivered = date;
        }
    }
}

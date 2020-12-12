namespace Globals
{
    public class HistoryOrder : IHistory
    {

        //public DateTime DateDeliveredTime { get; set; }
        public Order Order { get; set; }

        public HistoryOrder(Order order) //, DateTime dateTime
        {
            this.Order = order;
            // this.DateDeliveredTime = dateTime;
        }
    }
}

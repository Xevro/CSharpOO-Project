using System.Collections.Generic;

namespace Globals
{
    public interface ILogicInventory
    {
        List<Product> GetSortedProducts { get; }
        List<Order> GetSortedOrders { get; }
    }
}

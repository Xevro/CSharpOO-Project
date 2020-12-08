using System.Collections.Generic;

namespace Globals
{
    public interface IDataInventory
    {
        List<Product> GetSortedProducts { get; }
        List<Order> GetSortedOrders { get; }
    }
}

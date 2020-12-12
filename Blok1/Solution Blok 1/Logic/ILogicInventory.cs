using System.Collections.Generic;

namespace Globals
{
    public interface ILogicInventory
    {
        List<Product> GetSortedProducts { get; }
        List<Order> GetSortedOrders { get; }
        List<Order> GetSortedOrderHistory { get; }

        public void AddProduct(Product product);
        public void RemoveProduct(Product product);
        public void RemoveOrder(Order order);
        public void AddOrder(Order order, Product product, int quantityTxtField);
        public void ExportData();
        public void ImportData();
        public void ShowFileInfo();
        public void ShowDirectoryInfo();
    }
}

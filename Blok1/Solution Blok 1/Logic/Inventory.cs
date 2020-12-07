using Datalayer;
using Globals;
using System;
using System.Collections.Generic;

namespace Logic
{
    [Serializable]
    public class Inventory
    {
        public List<Product> Products = new List<Product>();
        public List<Order> Orders = new List<Order>();
        private readonly Data data = new Data();
        private readonly FileDirectoryData fileData = new FileDirectoryData();

        public void AddProduct(Product product)
        {
            if (!Products.Contains(product))
            {
                Products.Add(product);
            }
        }
        public void AddOrder(Order order, int quantity)
        {
            if (!Orders.Contains(order))
            {
                order.OrderQuantity = quantity;
                Orders.Add(order);
            }
            else
            {
                throw new OperationCanceledException("Can't add an order.");
            }
        }

        public void ExportData()
        {
            data.ExportToJSON(Products);
        }

        public void ImportData()
        {
            Products.AddRange(data.ImportFromJSON());
        }

        public void ShowFileInfo()
        {
            fileData.FileInfo();
        }
        public void ShowDirectoryInfo()
        {
            fileData.DirectoryInfo();
        }
    }
}

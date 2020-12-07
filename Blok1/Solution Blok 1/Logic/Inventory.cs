using Datalayer;
using Globals;
using System;
using System.Collections.Generic;
using System.Linq;

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
            if (!Products.Any(a => a.ProductCode == product.ProductCode))
            {
                Products.Add(product);
            }
            else
            {
                throw new OperationCanceledException("Can't add the product, it already exists");
            }
        }
        public void AddOrder(Order order, Product product)
        {
            if (!Orders.Any(a => a.OrderCode == order.OrderCode) || product.ProductStatus != ProductStatus.Outofstock)
            {
                Orders.Add(order);
            }
            else
            {
                throw new OperationCanceledException("Can't add the order, it already exists");
            }
        }

        public bool Equals(Product other)
        {
            if (other == null) return false;
            return (this.Products.Equals(other.ProductCode));
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

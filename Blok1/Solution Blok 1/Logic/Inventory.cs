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
        private readonly List<Product> Products = new List<Product>();
        private readonly List<Order> Orders = new List<Order>();
        private readonly Data data = new Data();
        private readonly FileDirectoryData fileData = new FileDirectoryData();

        public void AddProduct(Product product)
        {
            if (!Products.Any(a => a.ProductCode == product.ProductCode) || product.ProductQuantity > 1)
            {
                Products.Add(product);
            }
            else
            {
                throw new OperationCanceledException("Can't add the product.");
            }

            if (product.ProductQuantity <= 0)
            {
                product.ProductStatus = ProductStatus.Outofstock;
                //throw new 
            }
        }

        public List<Product> GetProducts()
        {
            return Products;
        }

        public List<Order> GetOrders()
        {
            return Orders;
        }

        public void RemoveProduct(Product product)
        {
            Products.RemoveAll(x => x.ProductCode == product.ProductCode);
        }

        public void AddOrder(Order order, Product product)
        {
            if (!Orders.Any(a => a.OrderCode == order.OrderCode) || product.ProductStatus != ProductStatus.Outofstock)
            {
                Orders.Add(order);
            }
            else
            {
                if (product.ProductStatus == ProductStatus.Outofstock)
                {
                    throw new OperationCanceledException("Product is out of stock");
                }
                else
                {
                    throw new OperationCanceledException("Can't add the order.");
                }
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

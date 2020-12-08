using Datalayer;
using Globals;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    [Serializable]
    public class Inventory : IDataInventory
    {
        private readonly List<Product> Products = new List<Product>();
        private readonly List<Order> Orders = new List<Order>();
        private readonly Data data = new Data();
        private readonly FileDirectoryData fileData = new FileDirectoryData();

        public List<Product> GetSortedProducts
        {
            get
            {
                List<Product> productsList = Products.OrderBy(p => p.ProductName).ToList();
                return productsList;
            }
        }

        public List<Order> GetSortedOrders
        {
            get
            {
                List<Order> ordersList = Orders.OrderBy(o => o.OrderName).ToList();
                return ordersList;
            }
        }

        public void AddProduct(Product product)
        {
            if (product.ProductQuantity <= 0)
            {
                throw new ArgumentOutOfRangeException("Quantity is to small, must be 1 at least.");
            }
            if (!Products.Any(a => a.ProductCode == product.ProductCode) && product.ProductQuantity >= 1)
            {
                Products.Add(product);
            }
            else
            {
                throw new OperationCanceledException("Can't add the product.");
            }
        }

        public void RemoveProduct(Product product)
        {
            Products.RemoveAll(x => x.ProductCode == product.ProductCode);
        }

        public void AddOrder(Order order, Product product, int quantityTxtField)
        {
            if ((product.ProductStatus == ProductStatus.Instock) && (quantityTxtField <= product.ProductQuantity))
            {
                product.ProductQuantity -= quantityTxtField;
                CheckProductStock(product);
                Orders.Add(order);

                if (product.ProductQuantity <= 8)
                {
                    throw new Exception($"Stock is running low on {product.ProductName}");
                }
                if (product.ProductQuantity == 0)
                {
                    product.ProductStatus = ProductStatus.Outofstock;
                    throw new OperationCanceledException("Product is out of stock");
                }
            }
            else
            {
                throw new OperationCanceledException("Can't place the order.");
            }
        }

        private void CheckProductStock(Product product)
        {
            if (product.ProductQuantity == 0)
            {
                product.ProductStatus = ProductStatus.Outofstock;
            }
        }

        /* public bool Equals(Product other)
         {
             if (other == null) return false;
             return (this.Products.Equals(other.ProductCode));
         }*/

        public void ExportData(string path)
        {
            data.ExportToJSON(Products, path);
        }

        public void ImportData()
        {
            Products.AddRange(data.ImportFromJSON(@"./ProductsData.json"));
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

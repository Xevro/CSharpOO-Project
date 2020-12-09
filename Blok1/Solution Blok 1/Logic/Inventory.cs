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
        private readonly List<Product> products = new List<Product>();
        private readonly List<Order> orders = new List<Order>();
        private readonly IDataProvider data = new Data();

        public List<Product> GetSortedProducts
        {
            get
            {
                var productsList = products.OrderBy(p => p.ProductName).ToList();
                return productsList;
            }
        }

        public List<Order> GetSortedOrders
        {
            get
            {
                var ordersList = orders.OrderBy(o => o.OrderName).ToList();
                return ordersList;
            }
        }

        public void AddProduct(Product product)
        {
            if (product.ProductQuantity <= 0)
            {
                throw new ArgumentOutOfRangeException("Quantity is to small, must be 1 at least.");
            }
            if (!products.Any(p => p == product) && product.ProductQuantity >= 1)
            {
                products.Add(product);
            }
            else
            {
                throw new OperationCanceledException("Can't add the product.");
            }
        }

        public void RemoveProduct(Product product)
        {
            products.RemoveAll(p => p == product);
        }
        public void RemoveOrder(Order order)
        {
            orders.RemoveAll(o => o == order);
        }

        public void AddOrder(Order order, Product product, int quantityTxtField)
        {
            if ((product.ProductStatus == ProductStatus.Instock) && (quantityTxtField <= product.ProductQuantity))
            {
                product.ProductQuantity -= quantityTxtField;
                CheckProductStock(product);
                orders.Add(order);

                if (product.ProductQuantity <= 8)
                {
                    throw new Exception($"Stock is running low on {product.ProductName}");
                }
                if (product.ProductQuantity == 0)
                {
                    product.ProductStatus = ProductStatus.Outofstock;
                    throw new SystemException("Product is out of stock");
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

        public void ExportData()
        {
            data.ExportToJSON(products);
        }

        public void ImportData()
        {
            var products = data.ImportFromJSON();
            if (products != null)
            {
                this.products.AddRange(products);
            }
            else
            {
                throw new Exception("Products data file is empty");
            }
        }

        public void ShowFileInfo()
        {
            data.FileInfo();
        }
        public void ShowDirectoryInfo()
        {
            data.DirectoryInfo();
        }
    }
}

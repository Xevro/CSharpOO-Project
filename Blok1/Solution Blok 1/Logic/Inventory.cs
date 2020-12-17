using Globals;
using Globals.ErrorMessages;
using Globals.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    [Serializable]
    public class Inventory : ILogicInventory
    {
        private readonly List<Product> products = new List<Product>();
        private readonly List<Order> orders = new List<Order>();
        private readonly List<HistoryOrder> ordersHistory = new List<HistoryOrder>();
        private readonly IDataProvider data;

        public Inventory(IDataProvider data)
        {
            this.data = data;
        }

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

        public List<HistoryOrder> GetSortedOrderHistory
        {
            get
            {
                var ordersList = ordersHistory.OrderBy(o => o.Order.OrderName).ToList();
                return ordersList;
            }
        }

        public void AddProduct(Product product)
        {
            if (product.ProductQuantity <= 0)
            {
                throw new AddingProductException(ErrorMessages.ProductQuantityTooLowError);
            }
            if (!products.Any(p => p.ProductCode == product.ProductCode) && product.ProductQuantity >= 1)
            {
                products.Add(product);
            }
            else
            {
                throw new AddingProductException(ErrorMessages.CanNotAddProductError);
            }
        }

        public void RemoveProduct(Product product)
        {
            products.RemoveAll(e => e.ProductCode == product.ProductCode);
        }

        public void RemoveOrder(Order order)
        {
            orders.RemoveAll(o => o.OrderCode == order.OrderCode);
        }

        public void AddOrder(Order order, Product product, int quantityTxtField)
        {
            if ((product.ProductStatus == ProductStatus.Instock) && (quantityTxtField <= product.ProductQuantity))
            {
                product.ProductQuantity -= quantityTxtField;
                CheckProductStock(product);
                orders.Add(order);
                AddToHistory(order);
                if (product.ProductQuantity <= 8)
                {
                    throw new ProductRunningLowOnStockException($"Stock is running low on {product.ProductName}");
                }
                if (product.ProductQuantity == 0)
                {
                    product.ProductStatus = ProductStatus.Outofstock;
                    throw new ProductOutOfstockException(ErrorMessages.ProductOutOfStockError);
                }
            }
            else
            {
                throw new AddingOrderException(ErrorMessages.CanNotAddOrderError);
            }
        }

        public void AddToHistory(Order order)
        {
            if (order.OrderStatus == OrderStatus.Delivered)
            {
                var d = new HistoryOrder(order.Shallowcopy(), DateTime.Today);
                ordersHistory.Add(d);
            }
        }

        public void UpdateProduct(Product product, int productID, string name, int quantity)
        {
            int index = products.FindLastIndex(p => p.ProductCode == product.ProductCode);
            if (index != -1)
            {
                var p = new Product(productID, name, quantity, product.ProductStatus);
                products[index] = p;
            }
        }

        public void UpdateOrder(Order order, OrderStatus status)
        {
            int index = orders.FindLastIndex(c => c.OrderCode == order.OrderCode);
            if (index != -1)
            {
                var o = new Order(order.OrderCode, order.OrderProductCode, order.OrderName, order.OrderQuantity, status);
                orders[index] = o;
            }
        }

        private void CheckProductStock(Product product)
        {
            if (product.ProductQuantity == 0) product.ProductStatus = ProductStatus.Outofstock;
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
                throw new ProductsDataIsEmptyException(ErrorMessages.ProductFileIsEmptyError);
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
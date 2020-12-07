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

        public void AddProduct(Product product)
        {
            if (!Products.Contains(product))
            {
                Products.Add(product);
            }
        }
        public void AddOrder(Order order)
        {
            if (!Orders.Contains(order))
            {
                Orders.Add(order);
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
    }
}

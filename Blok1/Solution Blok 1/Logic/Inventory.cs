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
        private readonly Data data = new Data();

        public void AddProduct(Product product)
        {
            if (!Products.Contains(product))
            {
                Products.Add(product);
            }
        }

        public void ExportData()
        {
            data.ExportToJSON(Products);
        }

        public List<Product> ImportData()
        {
            Products.AddRange(data.ImportFromJSON());
            return Products;
        }
    }
}

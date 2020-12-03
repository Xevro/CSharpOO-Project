using Globals;
using System.Collections.Generic;

namespace Logic
{
    public class Inventory
    {
        public List<Product> Products = new List<Product>();

        public void addProduct(Product product)
        {
            if (!Products.Contains(product))
            {
                Products.Add(product);
            }
        }
    }
}

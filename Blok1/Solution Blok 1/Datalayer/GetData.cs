﻿using Globals;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Datalayer
{
    public class GetData
    {
        private static string dataPath = "data.json";

        public static List<Product> LoadProducts()
        {
            List<Product> listOfProducts = new List<Product>();

            if (File.Exists(dataPath))
            {
                string json = File.ReadAllText("data.json");
                if (!string.IsNullOrWhiteSpace(json))
                {
                    listOfProducts = JsonConvert.DeserializeObject<List<Product>>(json);
                }
            };

            return listOfProducts;
        }

        public static void SaveProducts(List<Product> productsToSave)
        {
            if (!File.Exists(dataPath))
                File.Create(dataPath);

            string json = JsonConvert.SerializeObject(productsToSave);

            File.WriteAllText(dataPath, json);
        }

    }
}

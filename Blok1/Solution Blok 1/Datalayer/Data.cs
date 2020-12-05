using Globals;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Datalayer
{
    public class Data
    {

        public void ExportToJSON(List<Product> products)
        {
            var formatter = new Newtonsoft.Json.JsonSerializer();
            using var stream = new MemoryStream();
            using var sr = new StreamWriter(stream);
            formatter.Serialize(sr, products);
            sr.Flush();
            stream.Seek(0, SeekOrigin.Begin);

            FileStream f = new FileStream(@"./ProductsData.json", FileMode.OpenOrCreate);
            StreamWriter s = new StreamWriter(f);

            using var reader = new StreamReader(stream);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                s.WriteLine(line);
            }
            s.Close();
            f.Close();
        }

        public List<Product> ImportFromJSON()
        {
            try
            {
                string json = File.ReadAllText(@"./ProductsData.json");
                List<Product> productsFromFile = JsonConvert.DeserializeObject<List<Product>>(json);
                return productsFromFile;
            }
            catch (System.Exception)
            {
                Debug.WriteLine("error reading");
                throw;
            }

        }
    }
}


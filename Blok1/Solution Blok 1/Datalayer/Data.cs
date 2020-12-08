using Globals;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Datalayer
{
    public class Data : IDataProvider
    {
        public void ExportToJSON(List<Product> products, string path)
        {
            try
            {
                var formatter = new Newtonsoft.Json.JsonSerializer();
                using var stream = new MemoryStream();
                using var sr = new StreamWriter(stream);
                formatter.Serialize(sr, products);
                sr.Flush();
                stream.Seek(0, SeekOrigin.Begin);
                System.IO.File.WriteAllText(path, string.Empty);
                FileStream f = new FileStream(path, FileMode.OpenOrCreate);
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Product> ImportFromJSON(string path)
        {
            try
            {
                string json = File.ReadAllText(path);
                List<Product> productsFromFile = JsonConvert.DeserializeObject<List<Product>>(json);
                return productsFromFile;
            }
            catch (Exception)
            {
                throw new Exception("Error while importing from json file");
            }
        }
    }
}


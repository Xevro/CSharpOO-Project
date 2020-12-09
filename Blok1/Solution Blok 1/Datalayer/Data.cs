using Globals;
using Globals.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Datalayer
{
    public class Data : IDataProvider
    {
        public void ExportToJSON(List<Product> products)
        {
            try
            {
                string path = @"./ProductData.json";
                var formatter = new JsonSerializer();
                using var stream = new MemoryStream();
                using var sr = new StreamWriter(stream);
                formatter.Serialize(sr, products);
                sr.Flush();
                stream.Seek(0, SeekOrigin.Begin);
                System.IO.File.WriteAllText(path, string.Empty);
                var f = new FileStream(path, FileMode.OpenOrCreate);
                var s = new StreamWriter(f);

                using var reader = new StreamReader(stream);
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    s.WriteLine(line);
                }
                s.Close();
                f.Close();
            }
            catch (ExportDataException)
            {
                throw new ExportDataException("Can't export data to file");
            }
        }

        public List<Product> ImportFromJSON()
        {
            string path = @"Resources/ProductsData.json";

            if (!File.Exists(path))
            {
                File.Create(path);
            }
            try
            {
                string json = File.ReadAllText(path);
                var productsFromFile = JsonConvert.DeserializeObject<List<Product>>(json);
                return productsFromFile;
            }
            catch (ImportDataException)
            {
                throw new ImportDataException("Error while importing from json file");
            }
        }

        public void DirectoryInfo()
        {
            Console.WriteLine("Directory");
            Console.WriteLine("");
            var dir1 = new DirectoryInfo(@"./../../../../");

            Console.WriteLine($"Directories under {dir1.Name}");
            foreach (var dir in dir1.EnumerateDirectories())
            {
                Console.WriteLine($" {dir.Name}");
            }
            Console.WriteLine("");
        }

        public void FileInfo()
        {
            // list all files in C:\
            Console.WriteLine(@"Files in project directory");
            foreach (string fileName in Directory.EnumerateFiles(@"./../../../"))
            {
                var fileInfo = new FileInfo(fileName);
                Console.WriteLine($" {fileInfo.Name,-20} - {fileInfo.Length,10} bytes - created: {fileInfo.CreationTime}");
            }
            Console.WriteLine("");
        }
    }
}


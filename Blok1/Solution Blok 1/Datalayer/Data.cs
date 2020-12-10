using Globals;
using Globals.ErrorMessages;
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
                string path = @"Resources/ProductsData.json";

                string productsJson = JsonConvert.SerializeObject(products);
                File.WriteAllText(path, productsJson);
            }
            catch (ExportDataException)
            {
                throw new ExportDataException(ErrorMessages.ExportDataError);
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
                throw new ImportDataException(ErrorMessages.ImpotDataError);
            }
        }

        public void DirectoryInfo()
        {
            Console.WriteLine("Directory information");
            Console.WriteLine("");
            var dir1 = new DirectoryInfo(@"./");

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
            foreach (string fileName in Directory.EnumerateFiles(@"./"))
            {
                var fileInfo = new FileInfo(fileName);
                Console.WriteLine($" {fileInfo.Name,-20} - {fileInfo.Length,10} bytes - created: {fileInfo.CreationTime}");
            }
            Console.WriteLine("");
        }
    }
}
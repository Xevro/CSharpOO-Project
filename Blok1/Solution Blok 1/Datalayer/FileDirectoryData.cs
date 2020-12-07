using System;
using System.IO;
using Globals;

namespace Datalayer
{
    public class FileDirectoryData
    {
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

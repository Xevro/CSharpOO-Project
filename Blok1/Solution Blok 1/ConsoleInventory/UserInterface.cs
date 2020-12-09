using Logic;
using System;

namespace ConsoleInventory
{
    public class UserInterface
    {
        private readonly Inventory inv = new Inventory();

        public void Run()
        {
            ShowBanner();
        }

        private void ShowBanner()
        {
            Console.WriteLine("Console Inventory Application");
            Console.WriteLine("-----------------------------\n");
            Console.WriteLine("File & Directory information");
            inv.ShowFileInfo();
            inv.ShowDirectoryInfo();

        }
    }
}

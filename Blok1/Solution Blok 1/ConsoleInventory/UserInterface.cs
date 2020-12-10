using Globals;
using System;

namespace ConsoleInventory
{
    public class UserInterface
    {
        private readonly ILogicInventory inv;

        public UserInterface(ILogicInventory inventory)
        {
            this.inv = inventory;
        }

        public void Run()
        {
            inv.ImportData();
            ShowBanner();
        }

        private void ShowBanner()
        {
            Console.WriteLine("Console Inventory Application");
            Console.WriteLine("-----------------------------\n");
            Console.WriteLine("A list of all the products");
            foreach (var product in inv.GetSortedProducts)
            {
                Console.WriteLine(product);
            }

            //inv.ShowFileInfo();
            //inv.ShowDirectoryInfo();

        }
    }
}

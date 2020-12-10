using Globals;
using System;
using static System.Console;

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
            ShowStartBanner();
        }

        private void ShowStartBanner()
        {
            Console.WriteLine("Console Inventory Application");
            Console.WriteLine("-----------------------------\n");
            SelectOption();
        }

        private void SelectOption()
        {
            Console.WriteLine("1) View all the products");
            Console.WriteLine("2) View all the orders");
            Console.WriteLine("3) View folder information");
            Console.WriteLine("0) Exit the application");
            Console.WriteLine("Enter your choice:");
            bool exit = false;
            while (!exit)
            {
                string input = ReadLine();
                WriteLine();
                switch (input[0])
                {
                    case '0':
                        {
                            exit = true;
                            break;
                        }
                    case '1':
                        {
                            ShowProductsList();
                            break;
                        }
                    case '2':
                        {
                            ShowOrdersList();
                            break;
                        }
                    case '3':
                        {
                            inv.ShowFileInfo();
                            break;
                        }
                    default:
                        {
                            WriteLine("Invalid input, try again...");
                            break;
                        }
                }
            }
        }
        private void ShowProductsList()
        {
            Console.WriteLine("A list of all the products");
            foreach (var product in inv.GetSortedProducts)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine();
        }

        private void ShowOrdersList()
        {
            Console.WriteLine("A list of all the orders");
            foreach (var order in inv.GetSortedOrders)
            {
                Console.WriteLine(order);
            }
            Console.WriteLine();
        }
    }
}

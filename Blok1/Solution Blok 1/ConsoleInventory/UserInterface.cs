using System;

namespace ConsoleInventory
{
    public class UserInterface
    {

        public UserInterface()
        {
        }

        public void Run()
        {
            ShowBanner();
        }

        private void ShowBanner()
        {
            Console.WriteLine("Console Inventory Application");
            Console.WriteLine("-----------------------------\n");

            Double AmountEuro, AmountUsd;
            const Double Wisselkoers = 1.2231;

            Console.WriteLine("Enter your amount that you want to convert in Euro: ");
            AmountEuro = Convert.ToDouble(Console.ReadLine());

            AmountUsd = AmountEuro * Wisselkoers;

            Console.WriteLine($"Your €{AmountEuro.ToString()} is equal to ${AmountUsd.ToString()}");
            Console.ReadLine();
        }
    }
}

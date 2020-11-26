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
            Console.WriteLine("Console Inventory");
            Console.WriteLine("--------------\n");
        }
    }
}

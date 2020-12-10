using Datalayer;
using Logic;

namespace ConsoleInventory
{
    internal class ConsoleProgram
    {
        private static void Main()
        {
            var inv = new Inventory(new Data());
            new UserInterface(inv).Run();
        }
    }
}

using System;
using Globals;

namespace Logic
{
    public class Inventory
    {
        public Status Status { get; }
        public Item item { get; private set; }
    }
}

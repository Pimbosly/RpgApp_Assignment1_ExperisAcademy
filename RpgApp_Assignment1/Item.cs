using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgApp_Assignment1
{
    public abstract class Item
    {
        //properties
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public ItemSlot Slot { get; set; }

        //constructor
        protected Item(string name, int requiredLevel, ItemSlot slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgApp_Assignment1
{
    public class Armor : Item
    {
        public ArmorType ArmorType { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public Armor(string name, int requiredLevel, ItemSlot slot, ArmorType armorType, int strength, int dexterity, int intelligence) : base(name, requiredLevel, slot)
        {
            this.ArmorType = armorType;
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Intelligence = intelligence;
        }
    }
}

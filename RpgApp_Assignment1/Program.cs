using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgApp_Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mage mage = new Mage("Gandalf");
            Ranger ranger = new Ranger("Legolas");
            Rogue rogue = new Rogue("Frodo");
            Warrior warrior = new Warrior("Gimli");

            Console.WriteLine(mage.Name + " has a level of: " + mage.Level + " ,and an intelligence of: " + mage.Intelligence + " ,and a primaryattribute of: " + mage.GetPrimaryAttribute());
            mage.LevelUp();
            Console.WriteLine(mage.Name + " has a level of: " + mage.Level + " ,and an intelligence of: " + mage.Intelligence + " ,and a primaryattribute of: " + mage.GetPrimaryAttribute());
            mage.LevelUp();
            mage.EquipArmorClassCheck(new Armor("Shield of Cthulu", 3, ItemSlot.Body, ArmorType.Cloth, 10, 4, 6));
            Console.WriteLine(mage.Equipment[ItemSlot.Body].Name);
            mage.EquipArmorClassCheck(new Armor("Armor of Cthulu", 2, ItemSlot.Body, ArmorType.Cloth, 10, 4, 6));
            Console.WriteLine(mage.Equipment[ItemSlot.Body].Name);
            mage.Attack();
            mage.DisplayStats();
        }
    }
}

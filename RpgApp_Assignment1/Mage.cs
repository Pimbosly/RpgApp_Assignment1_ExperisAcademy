using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgApp_Assignment1
{
    public class Mage : CharacterClass
    {
        public Mage(string name) : base(name)
        {
            this.Intelligence = 8;
            this.Dexterity = 1;
            this.Strength = 1;

            Armor beginnerHead = new Armor("Beginner Cowl", 1, ItemSlot.Head, ArmorType.Cloth, 0, 0, 1);
            Armor beginnerBody = new Armor("Beginner Robe", 1, ItemSlot.Body, ArmorType.Cloth, 0, 0, 1);
            Armor beginnerLegs = new Armor("Beginner Pants", 1, ItemSlot.Legs, ArmorType.Cloth, 0, 0, 1);
            Weapon beginnerWeapon = new Weapon("Beginner Stick", 1, ItemSlot.Weapon, WeaponType.Wand, 1, 1);

            this.EquipArmor(beginnerHead);
            this.EquipArmor(beginnerBody);
            this.EquipArmor(beginnerLegs);
            this.EquipWeapon(beginnerWeapon);
        }

        public override string EquipArmorClassCheck(Armor armor)
        {
            //Mage may only equip cloth armors
            if(armor.ArmorType == ArmorType.Cloth)
            {
                this.EquipArmor(armor);
                return "New armour equipped!";
            }
            //If the armor is not made of cloth
            else
            {
                Console.WriteLine($"A mage can only equip a cloth armor. {this.Name} tried to equip a {armor.ArmorType.ToString()} called {armor.Name}");
                throw new InvalidArmorException(); 
            }
        }

        public override string EquipWeaponClassCheck(Weapon weapon)
        {
            //Mage may only equip a staff or a wand
            if(weapon.WeaponType == WeaponType.Staff || weapon.WeaponType == WeaponType.Wand)
            {
                this.EquipWeapon(weapon);
                return "New weapon equipped!";
            }
            //If it is not a staff or a wand
            else
            {
                Console.WriteLine($"A mage can only equip a staff or a wand. {this.Name} tried to equip a {weapon.WeaponType.ToString()} called {weapon.Name}");
                throw new InvalidWeaponException();
            }
        }

        public override int GetPrimaryAttribute()
        {
            return GetIntelligence();
        }

        public override void LevelUp()
        {
            this.Level++;
            this.Intelligence = this.Intelligence + 5;
            this.Strength++;
            this.Dexterity++;
            Console.WriteLine($"{this.Name} leveled up to level {this.Level}. They became stronger!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgApp_Assignment1
{
    public class Ranger : CharacterClass
    {
        public Ranger(string name) : base(name)
        {
            this.Dexterity = 7;
            this.Strength = 1;
            this.Intelligence = 1;

            Armor beginnerHead = new Armor("Beginner Hood", 1, ItemSlot.Head, ArmorType.Leather, 0, 1, 0);
            Armor beginnerBody = new Armor("Beginner Vest", 1, ItemSlot.Body, ArmorType.Leather, 0, 1, 0);
            Armor beginnerLegs = new Armor("Beginner Trousers", 1, ItemSlot.Legs, ArmorType.Leather, 0, 1, 0);
            Weapon beginnerWeapon = new Weapon("Beginner Bow", 1, ItemSlot.Weapon, WeaponType.Bow, 1, 1);

            this.EquipArmor(beginnerHead);
            this.EquipArmor(beginnerBody);
            this.EquipArmor(beginnerLegs);
            this.EquipWeapon(beginnerWeapon);
        }
        public override string EquipArmorClassCheck(Armor armor)
        {
            //ranger may only equip leather or mail armors
            if (armor.ArmorType == ArmorType.Leather || armor.ArmorType == ArmorType.Mail)
            {
                this.EquipArmor(armor);
                return "New armour equipped!";
            }
            //If the armor is not made of leather or mail
            else
            {
                Console.WriteLine($"A ranger can only equip a leather or mail armor. {this.Name} tried to equip a {armor.ArmorType.ToString()} called {armor.Name}");
                throw new InvalidArmorException();
            }
        }
        public override string EquipWeaponClassCheck(Weapon weapon)
        {
            //Ranger may only equip a bow
            if (weapon.WeaponType == WeaponType.Bow)
            {
                this.EquipWeapon(weapon);
                return "New weapon equipped!";
            }
            //If it is not a bow
            else
            {
                Console.WriteLine($"A ranger can only equip a bow. {this.Name} tried to equip a {weapon.WeaponType.ToString()} called {weapon.Name}");
                throw new InvalidWeaponException();
            }
        }

        public override int GetPrimaryAttribute()
        {
            return GetDexterity();
        }

        public override void LevelUp()
        {
            this.Level++;
            this.Dexterity = this.Dexterity + 5;
            this.Intelligence++;
            this.Strength++;
            Console.WriteLine($"{this.Name} leveled up to level {this.Level}. They became stronger!");
        }
    }
}

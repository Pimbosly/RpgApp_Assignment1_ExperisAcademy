using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgApp_Assignment1
{
    public class Warrior : CharacterClass
    {
        public Warrior(string name) : base(name)
        {
            this.Strength = 5;
            this.Dexterity = 2;
            this.Intelligence = 1;

            Armor beginnerHead = new Armor("Beginner Helmet", 1, ItemSlot.Head, ArmorType.Mail, 1, 0, 0);
            Armor beginnerBody = new Armor("Beginner Mail", 1, ItemSlot.Body, ArmorType.Mail, 1, 0, 0);
            Armor beginnerLegs = new Armor("Beginner MailPants", 1, ItemSlot.Legs, ArmorType.Mail, 1, 0, 0);
            Weapon beginnerWeapon = new Weapon("Beginner Sword", 1, ItemSlot.Weapon, WeaponType.Sword, 1, 1);

            this.EquipArmor(beginnerHead);
            this.EquipArmor(beginnerBody);
            this.EquipArmor(beginnerLegs);
            this.EquipWeapon(beginnerWeapon);
        }

        public override string EquipArmorClassCheck(Armor armor)
        {
            //warrior may only equip mail or plate armors
            if (armor.ArmorType == ArmorType.Mail || armor.ArmorType == ArmorType.Plate)
            {
                this.EquipArmor(armor);
                return "New armour equipped!";
            }
            //If the armor is not made of mail or plate
            else
            {
                Console.WriteLine($"A warrior can only equip a mail or plate armor. {this.Name} tried to equip a {armor.ArmorType.ToString()} called {armor.Name}");
                throw new InvalidArmorException();
            }
        }

        public override string EquipWeaponClassCheck(Weapon weapon)
        {
            //Warrior may only equip an axe, hammer or a sword
            if (weapon.WeaponType == WeaponType.Axe || weapon.WeaponType == WeaponType.Hammer || weapon.WeaponType == WeaponType.Sword)
            {
                this.EquipWeapon(weapon);
                return "New weapon equipped!";
            }
            //If it is not an axe, hammer or a sword
            else
            {
                Console.WriteLine($"A warrior can only equip an axe, hammer or a sword. {this.Name} tried to equip a {weapon.WeaponType.ToString()} called {weapon.Name}");
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
            this.Strength = this.Strength + 3;
            this.Dexterity = this.Dexterity + 2;
            this.Intelligence++;
            Console.WriteLine($"{this.Name} leveled up to level {this.Level}. They became stronger!");
        }
    }
}

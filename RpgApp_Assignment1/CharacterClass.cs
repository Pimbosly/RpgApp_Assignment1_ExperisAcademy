using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgApp_Assignment1
{
    public abstract class CharacterClass :ICharacterOptions
    {
        //properties
        public Dictionary<ItemSlot, Item> Equipment { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        //constructor
        protected CharacterClass(string name)
        {
            this.Name = name;
            this.Level = 1;
            this.Equipment = new Dictionary<ItemSlot, Item>();
        }

        //methods
        public abstract void LevelUp();
        public abstract string EquipWeaponClassCheck(Weapon weapon);
        public abstract string EquipArmorClassCheck(Armor armor);
        public abstract int GetPrimaryAttribute();
        public virtual void DisplayStats()
        {
            Console.Write(
                $"This is the character sheet of {Name} \n" +
                $"Level: {Level} \n" +
                $"Strength: {GetStrength()} \n" +
                $"Dexterity: {GetDexterity()} \n" +
                $"Intelligence: {GetIntelligence()} \n" +
                $"Damage: {CalculateDamage((Weapon)Equipment[ItemSlot.Weapon])}");
        }
        public virtual int GetStrength()
        {
            int head = ((Armor)Equipment[ItemSlot.Head]).Strength;
            int body = ((Armor)Equipment[ItemSlot.Body]).Strength;
            int legs = ((Armor)Equipment[ItemSlot.Legs]).Strength;
            return Strength + head + body + legs;
        }
        public virtual int GetDexterity()
        {
            int head = ((Armor)Equipment[ItemSlot.Head]).Dexterity;
            int body = ((Armor)Equipment[ItemSlot.Body]).Dexterity;
            int legs = ((Armor)Equipment[ItemSlot.Legs]).Dexterity;
            return Dexterity + head + body + legs;
        }

        public virtual int GetIntelligence()
        {
            int head = ((Armor)Equipment[ItemSlot.Head]).Intelligence;
            int body = ((Armor)Equipment[ItemSlot.Body]).Intelligence;
            int legs = ((Armor)Equipment[ItemSlot.Legs]).Intelligence;
            return Intelligence + head + body + legs;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name} attacked with their {Equipment[ItemSlot.Weapon].Name} and dealt {CalculateDamage((Weapon)Equipment[ItemSlot.Weapon])} amount of damage");
        }

        public virtual double CalculateDamage(Weapon weapon)
        {         
            return weapon.CalculateDPS() * (1 + GetPrimaryAttribute() / 100);
        }

        public virtual void EquipWeapon(Weapon weapon)
        {
            //cant equip a weapon as armor
            if (weapon.Slot == ItemSlot.Weapon)
            {
                //check if armor is not too high of level
                if (weapon.RequiredLevel <= Level)
                {
                    Equipment[weapon.Slot] = weapon;
                    Console.WriteLine($"{Name} equiped an weapon called {Equipment[weapon.Slot].Name}");
                    return;
                }
                //the armor is too high of level
                else
                {
                    Console.WriteLine($"{weapon.Name}'s level is too high for {Name}. {Name} is level {Level} while {weapon.Name} is meant for level {weapon.RequiredLevel} and higher.");
                    throw new InvalidWeaponException();
                }
            }
            else
            {
                Console.WriteLine($"{Name} can't equip an armorpiece as a weapon");
            }
        }

        public virtual void EquipArmor(Armor armor)
        {
            //cant equip a weapon as armor
            if(armor.Slot != ItemSlot.Weapon)
            {
                //check if armor is not too high of level
                if (armor.RequiredLevel <= this.Level)
                {
                    this.Equipment[armor.Slot] = armor;
                    Console.WriteLine($"{this.Name} equiped an armorpiece called {this.Equipment[armor.Slot].Name}");
                    return;
                }
                //the armor is too high of level
                else
                {
                    Console.WriteLine($"{armor.Name}'s level is too high for {this.Name}. {this.Name} is level {this.Level} while {armor.Name} is meant for level {armor.RequiredLevel} and higher.");
                    throw new InvalidArmorException();
                }
            }
            else
            {
                Console.WriteLine($"{this.Name} can't equip an armorpiece as a weapon");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgApp_Assignment1
{
    public class Weapon : Item
    {

        //properties
        public WeaponType WeaponType { get; set; }
        public int Damage { get; set; }
        public double AttackSpeed { get; set; }

        //constructor
        public Weapon(string name, int requiredLevel, ItemSlot slot, WeaponType weaponType, int damage, double attackSpeed) : base(name, requiredLevel, slot)
        {
            this.WeaponType = weaponType;
            this.Damage = damage;
            this.AttackSpeed = attackSpeed;
        }
        
        //methods
        public double CalculateDPS()
        {
            return Damage * AttackSpeed;
        }
    }
}

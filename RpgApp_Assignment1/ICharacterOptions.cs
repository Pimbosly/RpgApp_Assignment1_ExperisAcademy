using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgApp_Assignment1
{
    public interface ICharacterOptions
    {
        void LevelUp();
        string EquipWeaponClassCheck(Weapon weapon);
        string EquipArmorClassCheck(Armor amor);
        int GetPrimaryAttribute();
        int GetStrength();
        int GetDexterity();
        int GetIntelligence();
        void DisplayStats();
    }
}

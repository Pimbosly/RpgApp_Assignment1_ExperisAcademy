using RpgApp_Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RpgApp_Assignment1Tests
{
    public class ItemTests
    {
        //fields
        Warrior testWarrior = new Warrior("Gimli");
        Weapon axe = new Weapon("Common axe", 1, ItemSlot.Weapon, WeaponType.Axe, 7, 1.1);
        Weapon bow = new Weapon("Common bow", 1, ItemSlot.Weapon, WeaponType.Bow, 12, 0.8);
        Armor plate = new Armor("Common plate body armor", 1, ItemSlot.Body, ArmorType.Plate, 1, 0, 0);
        Armor cloth = new Armor("Common cloth head armor", 1, ItemSlot.Head, ArmorType.Cloth, 0, 0, 5);


        [Fact]
        public void Item_Weapon_Equip_HighLevel()
        {
            //Arrange
            axe.RequiredLevel = 2;
            //Act

            //Assert
            Assert.Throws<InvalidWeaponException>(() => testWarrior.EquipWeaponClassCheck(axe));
        }

        [Fact]
        public void Item_Armor_Equip_HighLevel()
        {
            //Arrange
            plate.RequiredLevel = 2;
            //Act

            //Assert
            Assert.Throws<InvalidArmorException>(() => testWarrior.EquipArmorClassCheck(plate));
        }

        [Fact]
        public void Item_Weapon_Equip_WrongType()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<InvalidWeaponException>(() => testWarrior.EquipWeaponClassCheck(bow));
        }

        [Fact]
        public void Item_Armor_Equip_WrongType()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<InvalidArmorException>(() => testWarrior.EquipArmorClassCheck(cloth));
        }

        [Fact]
        public void Item_Weapon_Equip_RightTypeMessage()
        {
            //Arrange
            string expected = "New weapon equipped!";
            //Act
            string actual = testWarrior.EquipWeaponClassCheck(axe);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Item_Armor_Equip_RightTypeMessage()
        {
            //Arrange
            string expected = "New armour equipped!";
            //Act
            string actual = testWarrior.EquipArmorClassCheck(plate);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Item_Damage_Calculate_NoWeapon()
        {
            //Arrange
            double expected = 1*(1+(5/100));
            //Act
            double actual = testWarrior.CalculateDamage((Weapon)testWarrior.Equipment[ItemSlot.Weapon]);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Item_Damage_Calculate_ValidWeapon()
        {
            //Arrange
            double expected = (7 * 1.1) * (1 + ((5) / 100));
            //Act
            testWarrior.EquipWeaponClassCheck(axe);
            double actual = testWarrior.CalculateDamage((Weapon)testWarrior.Equipment[ItemSlot.Weapon]);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Item_Damage_Calculate_ValidWeapon_ValidArmor()
        {
            //Arrange
            double expected = (7 * 1.1) * (1 + ((5 + 1) / 100));
            //Act
            testWarrior.EquipWeaponClassCheck(axe);
            testWarrior.EquipArmorClassCheck(plate);
            double actual = testWarrior.CalculateDamage((Weapon)testWarrior.Equipment[ItemSlot.Weapon]);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

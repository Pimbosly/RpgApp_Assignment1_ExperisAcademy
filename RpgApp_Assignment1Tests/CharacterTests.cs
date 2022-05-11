using RpgApp_Assignment1;
using Xunit;

namespace RpgApp_Assignment1Tests
{
    public class CharacterTests
    {
        //creation
        [Fact]
        public void Character_Creation_Level1_Mage()
        {
            //Arrange
            string name = "Gandalf";
            Mage testMage = new Mage(name);
            int expected = 1;
            //Act
            int actual = testMage.Level;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Character_Creation_Level1_Ranger()
        {
            //Arrange
            string name = "Legolas";
            Ranger testRanger = new Ranger(name);
            int expected = 1;
            //Act
            int actual = testRanger.Level;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Character_Creation_Level1_Rogue()
        {
            //Arrange
            string name = "Frodo";
            Rogue testRogue = new Rogue(name);
            int expected = 1;
            //Act
            int actual = testRogue.Level;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Character_Creation_Level1_Warrior()
        {
            //Arrange
            string name = "Gimli";
            Warrior testWarrior = new Warrior(name);
            int expected = 1;
            //Act
            int actual = testWarrior.Level;
            //Assert
            Assert.Equal(expected, actual);
        }


        //level up
        [Fact]
        public void Character_LevelUp_Mage()
        {
            //Arrange
            string name = "Gandalf";
            Mage testMage = new Mage(name);
            int expected = 2;
            //Act
            testMage.LevelUp();
            int actual = testMage.Level;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Character_LevelUp_Ranger()
        {
            //Arrange
            string name = "Legolas";
            Ranger testRanger = new Ranger(name);
            int expected = 2;
            //Act
            testRanger.LevelUp();
            int actual = testRanger.Level;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Character_LevelUp_Rogue()
        {
            //Arrange
            string name = "Frodo";
            Rogue testRogue = new Rogue(name);
            int expected = 2;
            //Act
            testRogue.LevelUp();
            int actual = testRogue.Level;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Character_LeelUp_Warrior()
        {
            //Arrange
            string name = "Gimli";
            Warrior testWarrior = new Warrior(name);
            int expected = 2;
            //Act
            testWarrior.LevelUp();
            int actual = testWarrior.Level;
            //Assert
            Assert.Equal(expected, actual);
        }


        //stats
        [Fact]
        public void Character_Creation_Stats_Mage()
        {
            //Arrange
            string name = "Gandalf";
            Mage testMage = new Mage(name);
            int[] expected = { 1, 1, 8 };
            //Act
            int[] actual = { testMage.Strength, testMage.Dexterity, testMage.Intelligence };
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Character_Creation_Stats_Ranger()
        {
            //Arrange
            string name = "Legolas";
            Ranger testRanger = new Ranger(name);
            int[] expected = { 1, 7, 1 };
            //Act
            int[] actual = { testRanger.Strength, testRanger.Dexterity, testRanger.Intelligence };
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Character_Creation_Stats_Rogue()
        {
            //Arrange
            string name = "Frodo";
            Rogue testRogue = new Rogue(name);
            int[] expected = { 2, 6, 1 };
            //Act
            int[] actual = { testRogue.Strength, testRogue.Dexterity, testRogue.Intelligence };
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Character_Creation_Stats_Warrior()
        {
            //Arrange
            string name = "Gimli";
            Warrior testWarrior = new Warrior(name);
            int[] expected = { 5, 2, 1 };
            //Act
            int[] actual = { testWarrior.Strength, testWarrior.Dexterity, testWarrior.Intelligence };
            //Assert
            Assert.Equal(expected, actual);
        }


        //stats on level up
        [Fact]
        public void Character_LevelUp_Stats_Mage()
        {
            //Arrange
            string name = "Gandalf";
            Mage testMage = new Mage(name);
            int[] expected = { 2, 2, 13 };
            //Act
            testMage.LevelUp();
            int[] actual = { testMage.Strength, testMage.Dexterity, testMage.Intelligence };
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Character_LevelUp_Stats_Ranger()
        {
            //Arrange
            string name = "Legolas";
            Ranger testRanger = new Ranger(name);
            int[] expected = { 2, 12, 2 };
            //Act
            testRanger.LevelUp();
            int[] actual = { testRanger.Strength, testRanger.Dexterity, testRanger.Intelligence };
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Character_LevelUp_Stats_Rogue()
        {
            //Arrange
            string name = "Frodo";
            Rogue testRogue = new Rogue(name);
            int[] expected = { 3, 10, 2 };
            //Act
            testRogue.LevelUp();
            int[] actual = { testRogue.Strength, testRogue.Dexterity, testRogue.Intelligence };
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Character_LevelUp_Stats_Warrior()
        {
            //Arrange
            string name = "Gimli";
            Warrior testWarrior = new Warrior(name);
            int[] expected = { 8, 4, 2 };
            //Act
            testWarrior.LevelUp();
            int[] actual = { testWarrior.Strength, testWarrior.Dexterity, testWarrior.Intelligence };
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
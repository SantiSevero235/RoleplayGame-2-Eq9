using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class EquipmentTest
    {
        private ICharacters archerTest;
        private ICharacters knightTest;
        private ICharacters dwarfTest;
        private Wizard wizardTest;
        private IEquipment armorTest;
        private IEquipment axeTest;
        private Staff staffTest;

        [SetUp]
        public void Setup()
        {
            archerTest = new Archer("Raul");
            knightTest = new Knight("Tusam");
            dwarfTest = new Dwarf("Thomas");
            wizardTest = new Wizard("Gandalf");
            staffTest = new Staff();
            armorTest = new Armor();
            axeTest = new Axe();
        }
        [Test]
        public void WizardEquipStaffDefence()
        {
            wizardTest.Equip(staffTest);
            int expected = 100;
            Assert.AreEqual(expected, wizardTest.DefenseValue);
        }
        [Test]
        public void WizardEquipStaffAttack()
        {
            wizardTest.Equip(staffTest);
            int expected = 100;
            Assert.AreEqual(expected, wizardTest.AttackValue);  
        }


        [Test]
        public void WizardUnequipStaffAttack()
        {
            wizardTest.Equip(staffTest);
            wizardTest.Unequip(staffTest);
            int expected = 0;
            Assert.AreEqual(expected, wizardTest.AttackValue);
        }
        [Test]
        public void WizardUnequipStaffDefence()
        {
            wizardTest.Equip(staffTest);
            wizardTest.Unequip(staffTest);
            int expected = 0;
            Assert.AreEqual(expected, wizardTest.DefenseValue);
        }

        [Test]
        public void DwarfEquipAxeDefence()
        {
            dwarfTest.Equip(axeTest);
            int expected = 0;
            Assert.AreEqual(expected, dwarfTest.DefenseValue);
        }
        [Test]
        public void DwarfEquipAxeAttack()
        {
            dwarfTest.Equip(axeTest);
            int expected = 25;
            Assert.AreEqual(expected, dwarfTest.AttackValue);  
        }


        [Test]
        public void DwarfUnequipAxeAttack()
        {
            dwarfTest.Equip(axeTest);
            dwarfTest.Unequip(axeTest);
            int expected = 0;
            Assert.AreEqual(expected, dwarfTest.AttackValue);
        }
        [Test]
        public void DwarfUnequipAxeDefence()
        {
            dwarfTest.Equip(axeTest);
            dwarfTest.Unequip(axeTest);
            int expected = 0;
            Assert.AreEqual(expected, dwarfTest.DefenseValue);
        }
        [Test]
        public void DwarfEquipArmorDefence()
        {
            dwarfTest.Equip(armorTest);
            int expected = 25;
            Assert.AreEqual(expected, dwarfTest.DefenseValue);
        }
        [Test]
        public void DwarfEquipArmorAttack()
        {
            dwarfTest.Equip(armorTest);
            int expected = 0;
            Assert.AreEqual(expected, dwarfTest.AttackValue);  
        }


        [Test]
        public void DwarfUnequipArmorAttack()
        {
            dwarfTest.Equip(armorTest);
            dwarfTest.Unequip(armorTest);
            int expected = 0;
            Assert.AreEqual(expected, dwarfTest.AttackValue);
        }
        [Test]
        public void DwarfUnequipArmorDefence()
        {
            dwarfTest.Equip(armorTest);
            dwarfTest.Unequip(armorTest);
            int expected = 0;
            Assert.AreEqual(expected, dwarfTest.DefenseValue);
        }

    }
}
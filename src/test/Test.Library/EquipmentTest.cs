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

        // Se prueba si al equipar un baculo se modifica correctamente la defensa
        [Test]
        public void WizardEquipStaffDefense()
        {
            int expected = dwarfTest.DefenseValue + staffTest.DefenseValue;
            wizardTest.Equip(staffTest);
            Assert.AreEqual(expected, wizardTest.DefenseValue);
        }

        // Se prueba si al equipar un baculo se modifica correctamente el ataque
        [Test]
        public void WizardEquipStaffAttack()
        {
            int expected = dwarfTest.AttackValue + staffTest.AttackValue;
            wizardTest.Equip(staffTest);
            Assert.AreEqual(expected, wizardTest.AttackValue);  
        }

        // Se prueba si al desequipar un baculo se modifica correctamente el ataque
        [Test]
        public void WizardUnequipStaffAttack()
        {
            int expected = dwarfTest.AttackValue;
            wizardTest.Equip(staffTest);
            wizardTest.Unequip(staffTest);
            Assert.AreEqual(expected, wizardTest.AttackValue);
        }

        // Se prueba si al desequipar un baculo se modifica correctamente la defensa
        [Test]
        public void WizardUnequipStaffDefense()
        {
            int expected = dwarfTest.DefenseValue; 
            wizardTest.Equip(staffTest);
            wizardTest.Unequip(staffTest);
            Assert.AreEqual(expected, wizardTest.DefenseValue);
        }

        // Se prueba si al equipar un item de ataque se modifica correctamente la defensa
        [Test]
        public void DwarfEquipAxeDefense()
        {
            dwarfTest.Equip(axeTest);
            int expected = 0;
            Assert.AreEqual(expected, dwarfTest.DefenseValue);
        }

        // Se prueba si al equipar un item de ataque se modifica correctamente el ataque
        [Test]
        public void DwarfEquipAxeAttack()
        {
            dwarfTest.Equip(axeTest);
            int expected = 25;
            Assert.AreEqual(expected, dwarfTest.AttackValue);  
        }

        // Se prueba si al desequipar un item de ataque se modifica correctamente el ataque
        [Test]
        public void DwarfUnequipAxeAttack()
        {
            dwarfTest.Equip(axeTest);
            dwarfTest.Unequip(axeTest);
            int expected = 0;
            Assert.AreEqual(expected, dwarfTest.AttackValue);
        }

        // Se prueba si al desequipar un item de ataque se modifica correctamente la defensa
        [Test]
        public void DwarfUnequipAxeDefense()
        {
            dwarfTest.Equip(axeTest);
            dwarfTest.Unequip(axeTest);
            int expected = 0;
            Assert.AreEqual(expected, dwarfTest.DefenseValue);
        }

        // Se prueba si al equipar un item de defensa se modifica correctamente la defensa
        [Test]
        public void DwarfEquipArmorDefense()
        {
            dwarfTest.Equip(armorTest);
            int expected = 25;
            Assert.AreEqual(expected, dwarfTest.DefenseValue);
        }

        // Se prueba si al equipar un item de defensa se modifica correctamente el ataque
        [Test]
        public void DwarfEquipArmorAttack()
        {
            dwarfTest.Equip(armorTest);
            int expected = 0;
            Assert.AreEqual(expected, dwarfTest.AttackValue);  
        }

        // Se prueba si al desequipar un item de defensa se modifica correctamente el ataque
        [Test]
        public void DwarfUnequipArmorAttack()
        {
            dwarfTest.Equip(armorTest);
            dwarfTest.Unequip(armorTest);
            int expected = 0;
            Assert.AreEqual(expected, dwarfTest.AttackValue);
        }

        // Se prueba si al desequipar un item de defensa se modifica correctamente la defensa
        [Test]
        public void DwarfUnequipArmorDefense()
        {
            dwarfTest.Equip(armorTest);
            dwarfTest.Unequip(armorTest);
            int expected = 0;
            Assert.AreEqual(expected, dwarfTest.DefenseValue);
        }

    }
}
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
            int expected = wizardTest.DefenseValue + staffTest.DefenseValue;
            wizardTest.Equip(staffTest);
            Assert.AreEqual(expected, wizardTest.DefenseValue);
        }

        // Se prueba si al equipar un baculo se modifica correctamente el ataque
        [Test]
        public void WizardEquipStaffAttack()
        {
            int expected = wizardTest.AttackValue + staffTest.AttackValue;
            wizardTest.Equip(staffTest);
            Assert.AreEqual(expected, wizardTest.AttackValue);  
        }

        // Se prueba si al desequipar un baculo se modifica correctamente el ataque
        [Test]
        public void WizardUnequipStaffAttack()
        {
            int expected = wizardTest.AttackValue;
            wizardTest.Equip(staffTest);
            wizardTest.Unequip(staffTest);
            Assert.AreEqual(expected, wizardTest.AttackValue);
        }

        // Se prueba si al desequipar un baculo se modifica correctamente la defensa
        [Test]
        public void WizardUnequipStaffDefense()
        {
            int expected = wizardTest.DefenseValue;
            wizardTest.Equip(staffTest);
            wizardTest.Unequip(staffTest);
            Assert.AreEqual(expected, wizardTest.DefenseValue);
        }

        // Se prueba si al equipar un item de ataque se modifica correctamente la defensa
        [Test]
        public void DwarfEquipAxeDefense()
        {
            int expected = dwarfTest.DefenseValue + axeTest.DefenseValue;
            dwarfTest.Equip(axeTest);
            Assert.AreEqual(expected, dwarfTest.DefenseValue);
        }

        // Se prueba si al equipar un item de ataque se modifica correctamente el ataque
        [Test]
        public void DwarfEquipAxeAttack()
        {
            int expected = dwarfTest.AttackValue + axeTest.AttackValue;
            dwarfTest.Equip(axeTest);
            Assert.AreEqual(expected, dwarfTest.AttackValue);  
        }

        // Se prueba si al desequipar un item de ataque se modifica correctamente el ataque
        [Test]
        public void DwarfUnequipAxeAttack()
        {
            int expected = wizardTest.AttackValue;
            dwarfTest.Equip(axeTest);
            dwarfTest.Unequip(axeTest);
            Assert.AreEqual(expected, dwarfTest.AttackValue);
        }

        // Se prueba si al desequipar un item de ataque se modifica correctamente la defensa
        [Test]
        public void DwarfUnequipAxeDefense()
        {
            int expected = wizardTest.DefenseValue;
            dwarfTest.Equip(axeTest);
            dwarfTest.Unequip(axeTest);
            Assert.AreEqual(expected, dwarfTest.DefenseValue);
        }

        // Se prueba si al equipar un item de defensa se modifica correctamente la defensa
        [Test]
        public void DwarfEquipArmorDefense()
        {
            int expected = dwarfTest.DefenseValue + armorTest.DefenseValue;
            dwarfTest.Equip(armorTest);
            Assert.AreEqual(expected, dwarfTest.DefenseValue);
        }

        // Se prueba si al equipar un item de defensa se modifica correctamente el ataque
        [Test]
        public void DwarfEquipArmorAttack()
        {
            int expected = dwarfTest.AttackValue + armorTest.AttackValue;
            dwarfTest.Equip(armorTest);
            Assert.AreEqual(expected, dwarfTest.AttackValue);  
        }

        // Se prueba si al desequipar un item de defensa se modifica correctamente el ataque
        [Test]
        public void DwarfUnequipArmorAttack()
        {
            int expected = dwarfTest.AttackValue;
            dwarfTest.Equip(armorTest);
            dwarfTest.Unequip(armorTest);
            Assert.AreEqual(expected, dwarfTest.AttackValue);
        }

        // Se prueba si al desequipar un item de defensa se modifica correctamente la defensa
        [Test]
        public void DwarfUnequipArmorDefense()
        {
            int expected = dwarfTest.DefenseValue;
            dwarfTest.Equip(armorTest);
            dwarfTest.Unequip(armorTest);
            Assert.AreEqual(expected, dwarfTest.DefenseValue);
        }

    }
}
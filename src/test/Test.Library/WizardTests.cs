using NUnit.Framework;
using System;
using RoleplayGame;


namespace Test.Library
{
    /// <summary>
    /// Se crearon los test de la clase wizard por seperado, debido a que posee atributos y metodos distinto a
    /// los demas ICharacters, por lo cual merece un testing mas exhaustivo debido a sus caracteristicas magicas.
    /// </summary>
    public class WizardTests
    {
        private Wizard wizardTest;
        private Staff staffTest;
        private SpellsBook spellsBookTest;
        private Spell spellTest1;
        private Spell spellTest2;
        private Spell spellTest3;
        private Spell spellTest4;
        private Dwarf dwarfTest;
        private Armor armorTest;
        private Axe axeTest;


        [SetUp]
        public void Setup()
        {
            wizardTest = new Wizard("Richy");
            staffTest = new Staff();
            spellsBookTest = new SpellsBook();
            spellTest1 = new Spell();
            spellTest2 = new Spell();
            spellTest3 = new Spell();
            spellTest4 = new Spell();
            dwarfTest = new Dwarf("Thomas");
            armorTest = new Armor();
            axeTest = new Axe();
        }

        [Test]
        public void WizardEquipSpells()
        {
            wizardTest.EquipSpellbook(spellsBookTest);
            spellsBookTest.Spells = new Spell[]{spellTest1, spellTest2, spellTest3, spellTest4};
            int expected = 70*4;
            Assert.AreEqual(expected, wizardTest.AttackValue);
            Assert.AreEqual(expected, wizardTest.DefenseValue);
        }

        [Test]
        public void WizardEquipStaff()
        {
            wizardTest.EquipSpellbook(spellsBookTest);
            spellsBookTest.Spells = new Spell[]{ new Spell() };
            wizardTest.Equip(staffTest);
            int expected = 70 + 100;
            Assert.AreEqual(expected, wizardTest.AttackValue);
            Assert.AreEqual(expected, wizardTest.DefenseValue);
        }

        [Test]
        public void WizardUnequipStaff()
        {
            wizardTest.EquipSpellbook(spellsBookTest);
            spellsBookTest.Spells = new Spell[]{ new Spell() };
            wizardTest.Equip(staffTest);
            wizardTest.Unequip(staffTest);
            int expected = 70;
            Assert.AreEqual(expected, wizardTest.AttackValue);
            Assert.AreEqual(expected, wizardTest.DefenseValue);
        }

        [Test]
        public void WizardDefenseSpells()
        {
            wizardTest.EquipSpellbook(spellsBookTest);
            spellsBookTest.Spells = new Spell[]{ new Spell() };
            int expecteddamage = 0;
            dwarfTest.Equip(axeTest);
            if (dwarfTest.AttackValue - wizardTest.DefenseValue > 0)
            {
                expecteddamage = dwarfTest.AttackValue - wizardTest.DefenseValue;
            }
            int expectedLifeAfterAttack = 0;
            if ((wizardTest.Health - expecteddamage) > 0)
                expectedLifeAfterAttack = wizardTest.Health - expecteddamage;
            wizardTest.ReceiveAttack(dwarfTest.AttackValue);
            Assert.AreEqual(expectedLifeAfterAttack, wizardTest.Health);
        }

        [Test]
        public void WizardAttackSpells()
        {
            wizardTest.EquipSpellbook(spellsBookTest);
            spellsBookTest.Spells = new Spell[]{ new Spell() };
            int expecteddamage = 0;
            dwarfTest.Equip(armorTest);
            if (wizardTest.AttackValue - dwarfTest.DefenseValue > 0)
            {
                expecteddamage = wizardTest.AttackValue - dwarfTest.DefenseValue;
            }
            int expectedLifeAfterAttack = 0;
            if ((dwarfTest.Health - expecteddamage) > 0)
                expectedLifeAfterAttack = dwarfTest.Health - expecteddamage;
            dwarfTest.ReceiveAttack(wizardTest.DefenseValue);
            Assert.AreEqual(expectedLifeAfterAttack, dwarfTest.Health);
        }

        [Test]
        public void WizardDefenseStaff()
        {
            wizardTest.EquipSpellbook(spellsBookTest);
            spellsBookTest.Spells = new Spell[]{ new Spell() };
            wizardTest.Equip(staffTest);
            int expecteddamage = 0;
            dwarfTest.Equip(axeTest);
            if (dwarfTest.AttackValue - wizardTest.DefenseValue > 0)
            {
                expecteddamage = dwarfTest.AttackValue - wizardTest.DefenseValue;
            }
            int expectedLifeAfterAttack = 0;
            if ((wizardTest.Health - expecteddamage) > 0)
                expectedLifeAfterAttack = wizardTest.Health - expecteddamage;
            wizardTest.ReceiveAttack(dwarfTest.AttackValue);
            Assert.AreEqual(expectedLifeAfterAttack, wizardTest.Health);
        }

        [Test]
        public void WizardAttackStaff()
        {
            wizardTest.EquipSpellbook(spellsBookTest);
            spellsBookTest.Spells = new Spell[]{};
            wizardTest.Equip(staffTest);
            int expecteddamage = 0;
            dwarfTest.Equip(armorTest);
            if (wizardTest.AttackValue - dwarfTest.DefenseValue > 0)
            {
                expecteddamage = wizardTest.AttackValue - dwarfTest.DefenseValue;
            }
            int expectedLifeAfterAttack = 0;
            if ((dwarfTest.Health - expecteddamage) > 0)
                expectedLifeAfterAttack = dwarfTest.Health - expecteddamage;
            dwarfTest.ReceiveAttack(wizardTest.DefenseValue);
            Assert.AreEqual(expectedLifeAfterAttack, dwarfTest.Health);
        }

        [Test]
        public void WizardAttackWithAll()
        {
            wizardTest.EquipSpellbook(spellsBookTest);
            spellsBookTest.Spells = new Spell[]{ new Spell() };
            wizardTest.Equip(staffTest);
            int expecteddamage = 0;
            dwarfTest.Equip(armorTest);
            if (wizardTest.AttackValue - dwarfTest.DefenseValue > 0)
            {
                expecteddamage = wizardTest.AttackValue - dwarfTest.DefenseValue;
            }
            int expectedLifeAfterAttack = 0;
            if ((dwarfTest.Health - expecteddamage) > 0)
                expectedLifeAfterAttack = dwarfTest.Health - expecteddamage;
            dwarfTest.ReceiveAttack(wizardTest.DefenseValue);
            Assert.AreEqual(expectedLifeAfterAttack, dwarfTest.Health);
        }
    }
}
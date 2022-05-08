using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class TestAtaque
    {
        private ICharacters archerTest;
        private ICharacters knightTest;
        private ICharacters dwarfTest;
        private IEquipment armorTest;
        private IEquipment axeTest;

        [SetUp]
        public void Setup()
        {
            archerTest = new Archer("Raul");
            knightTest = new Knight("Tusam");
            dwarfTest = new Dwarf("Thomas");
            armorTest = new Armor();
            axeTest = new Axe();
        }

        [Test]

        public void Damage0vsDefense0()
        {
            int expecteddamage = 0;
            if (archerTest.AttackValue - dwarfTest.DefenseValue > 0)
            {
                expecteddamage = archerTest.AttackValue - dwarfTest.DefenseValue;
            }
            int expectedLifeAfterAttack = 0;
            if ((dwarfTest.Health - expecteddamage) > 0)
                expectedLifeAfterAttack = dwarfTest.Health - expecteddamage;
            dwarfTest.ReceiveAttack(archerTest.AttackValue);
            Assert.AreEqual(expectedLifeAfterAttack, dwarfTest.Health);
        }

        [Test]

        public void DamagevsDefense0()
        {
            int expecteddamage = 0;
            knightTest.Equip(axeTest);
            if (knightTest.AttackValue - archerTest.DefenseValue > 0)
            {
                expecteddamage = knightTest.AttackValue - archerTest.DefenseValue;
            }
            int expectedLifeAfterAttack = 0;
            if ((archerTest.Health - expecteddamage) > 0)
                expectedLifeAfterAttack = archerTest.Health - expecteddamage;
            archerTest.ReceiveAttack(knightTest.AttackValue);

            Assert.AreEqual(expectedLifeAfterAttack, archerTest.Health);
        }

        [Test]
        public void Damage0vsDefense()
        {
            int expecteddamage = 0;
            archerTest.Equip(armorTest);
            if (knightTest.AttackValue - archerTest.DefenseValue > 0)
            {
                expecteddamage = knightTest.AttackValue - archerTest.DefenseValue;
            }
            int expectedLifeAfterAttack = 0;
            if ((archerTest.Health - expecteddamage) > 0)
                expectedLifeAfterAttack = archerTest.Health - expecteddamage;
            archerTest.ReceiveAttack(knightTest.AttackValue);

            Assert.AreEqual(expectedLifeAfterAttack, archerTest.Health);
        }
              
        [Test]
        public void DamagevsDefense()
        {
            int expecteddamage = 0;
            archerTest.Equip(armorTest);
            knightTest.Equip(axeTest);
            if (knightTest.AttackValue - archerTest.DefenseValue > 0)
            {
                expecteddamage = knightTest.AttackValue - archerTest.DefenseValue;
            }
            int expectedLifeAfterAttack = 0;
            if ((archerTest.Health - expecteddamage) > 0)
                expectedLifeAfterAttack = archerTest.Health - expecteddamage;
            archerTest.ReceiveAttack(knightTest.AttackValue);

            Assert.AreEqual(expectedLifeAfterAttack, archerTest.Health);  
        }
    }
}
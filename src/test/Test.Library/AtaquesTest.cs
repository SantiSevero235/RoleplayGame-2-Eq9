using NUnit.Framework;
using RoleplayGame;


namespace Test.Library
{
    [TestFixture]
    public class TestAtaque
    {
        private Archer ArcherTest;
        private Knight KnightTest;
        private Dwarf DwarfTest;
        private Wizard WizardTest;
        private SpellsBook book;

        [SetUp]
        public void Setup()
        {
            ArcherTest = new Archer("Raul");
            ArcherTest.Bow = new Bow();
            ArcherTest.Helmet = new Helmet();
            KnightTest = new Knight("Tusam");
            KnightTest.Armor = new Armor();
            KnightTest.Shield = new Shield();
            KnightTest.Sword = new Sword();
            WizardTest = new Wizard("Richy");
            book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };
            WizardTest.Staff = new Staff();
            DwarfTest = new Dwarf("Thomas");
            DwarfTest.Axe = new Axe();
            DwarfTest.Helmet = new Helmet();
            DwarfTest.Shield = new Shield();
        }

        [Test]

        public void Test1_0()
        {

        }
        [Test]

        public void Test1_0()
        {
              
        }
    }
}
using NUnit.Framework;
using System;
using RoleplayGame;


namespace Test.Library
{

    [TestFixture]
    public class Example
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

/*
atacar con hechizo
    atacar con staff
    atacar con ambos
añadir hechizos a libro
equipar libro
equipar
desequipar
    curar
*/

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
            int expectedLifeAfterAttack = wizardTest.Health - expecteddamage;
            wizardTest.ReceiveAttack(dwarfTest.AttackValue);
            Assert.AreEqual(expectedLifeAfterAttack, wizardTest.Health);
        }

        [Test]
        public void WizardAttackSpells()
        {
            wizardTest.EquipSpellbook(spellsBookTest);
            spellsBookTest.Spells = new Spell[]{ new Spell() };
            int expecteddamage = 70;
            dwarfTest.Equip(armorTest);
            if (wizardTest.AttackValue - dwarfTest.DefenseValue > 0)
            {
                expecteddamage = wizardTest.AttackValue - dwarfTest.DefenseValue;
            }
            int expectedLifeAfterAttack = dwarfTest.Health - expecteddamage;
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
            int expectedLifeAfterAttack = wizardTest.Health - expecteddamage;
            wizardTest.ReceiveAttack(dwarfTest.AttackValue);
            Assert.AreEqual(expectedLifeAfterAttack, wizardTest.Health);
        }

        [Test]
        public void WizardAttackStaff()
        {
            wizardTest.EquipSpellbook(spellsBookTest);
            spellsBookTest.Spells = new Spell[]{ new Spell() };
            wizardTest.Equip(staffTest);
            int expecteddamage = 100+70;
            dwarfTest.Equip(armorTest);
            if (wizardTest.AttackValue - dwarfTest.DefenseValue > 0)
            {
                expecteddamage = wizardTest.AttackValue - dwarfTest.DefenseValue;
            }
            int expectedLifeAfterAttack = dwarfTest.Health - expecteddamage;
            dwarfTest.ReceiveAttack(wizardTest.DefenseValue);
            Assert.AreEqual(expectedLifeAfterAttack, dwarfTest.Health);
        }
/*

        [Test]
        /// <summary>
        /// Pruebo el hechizo inicial con el que se crean los magos y ademas si funciona
        /// el ataque entre magos
        /// </summary>
        public void HechizoInicial()
        {
            int dañoEsperado = 0;
            int dañoDeHechizo = WizardTest.UsarHechizoparaAtaque("Hechizo inicial");
            if ((dañoDeHechizo - WizardTest2.Defensa) > 0)
                dañoEsperado = dañoDeHechizo - WizardTest2.Defensa;
            int vidaDespuesAtaque = WizardTest2.VidaActual - dañoEsperado;
            AtaquesconHechizo.AtaqueaWizard(WizardTest,"Hechizo inicial",WizardTest2);
            Assert.AreEqual(vidaDespuesAtaque, WizardTest2.VidaActual);
        }

        [Test]
        /// <summary>
        /// Pruebo crear un hechizo y ver si su daño se graba correctamente y se utiliza luego al atacar.
        /// </summary>
        public void Hechizonuevo_daño()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            WizardTest.AprenderHechizo("cataplumba",dañoDeHechizo,defensaDeHechizo);
            int dañoEsperado = 0;
            int dañoporHechizo = WizardTest.UsarHechizoparaAtaque("cataplumba");

            if ((dañoporHechizo - WizardTest2.Defensa) > 0)
                dañoEsperado = dañoporHechizo - WizardTest2.Defensa;
            int vidaDespuesAtaque = WizardTest2.VidaActual - dañoEsperado;
            AtaquesconHechizo.AtaqueaWizard(WizardTest,"cataplumba",WizardTest2);
            Assert.AreEqual(vidaDespuesAtaque, WizardTest2.VidaActual);          

        }
        
        [Test]
        // Prueba si se aumenta correctamente la defensa al utilizar un hechizo creado
        public void Hechizonuevo_defender()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            WizardTest.AprenderHechizo("cataplumba",dañoDeHechizo,defensaDeHechizo);
            int defensaDespuesdeHechizo = WizardTest.Defensa + defensaDeHechizo;
            WizardTest.UsarHechizoparaDefensa("cataplumba");
            Assert.AreEqual(defensaDespuesdeHechizo, WizardTest.Defensa);
        }
        
        [Test]
        // Pruebo si cuando se crean dos hechizos iguales y se intentan añadir al libro de hechizos, se mantiene el primero con su atributo defensa intacto
        public void Hechizosnuevos_defender2()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            int dañoDeHechizo2 = 2233;
            int defensaDeHechizo2 = 1234;
            WizardTest.AprenderHechizo("cataplumba",dañoDeHechizo,defensaDeHechizo);
            WizardTest.AprenderHechizo("cataplumba",dañoDeHechizo2,defensaDeHechizo2);
            int defensaDespuesdeHechizo = WizardTest.Defensa + defensaDeHechizo;
            WizardTest.UsarHechizoparaDefensa("cataplumba");
            Assert.AreEqual(defensaDespuesdeHechizo, WizardTest.Defensa);
        }

        [Test]
        // Pruebo si cuando se crean dos hechizos iguales y se intentan añadir al libro de hechizos, se mantiene el primero con su atributo daño intacto
        public void Hechizonuevos_daño()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            int dañoDeHechizo2 = 2212;
            int defensaDeHechizo2 = 1233;
            WizardTest.AprenderHechizo("cataplumba",dañoDeHechizo,defensaDeHechizo);
            WizardTest.AprenderHechizo("cataplumba",dañoDeHechizo2,defensaDeHechizo2);
            int dañoEsperado = 0;
            int dañoporHechizo = WizardTest.UsarHechizoparaAtaque("cataplumba");

            if ((dañoporHechizo - WizardTest2.Defensa) > 0)
                dañoEsperado = dañoporHechizo - WizardTest2.Defensa;
            int vidaDespuesAtaque = WizardTest2.VidaActual - dañoEsperado;
            AtaquesconHechizo.AtaqueaWizard(WizardTest,"cataplumba",WizardTest2);
            Assert.AreEqual(vidaDespuesAtaque, WizardTest2.VidaActual);          
        }

        [Test]
        // Pruebo si al grabar dos hechizos, se almacena correctamente la defensa del primero
        public void Hechizosnuevos_defender2_Hechizosdistintos_1()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            int dañoDeHechizo2 = 2233;
            int defensaDeHechizo2 = 1234;
            WizardTest.AprenderHechizo("cataplumba",dañoDeHechizo,defensaDeHechizo);
            WizardTest.AprenderHechizo("Silantro",dañoDeHechizo2,defensaDeHechizo2);
            int defensaDespuesdeHechizo = WizardTest.Defensa + defensaDeHechizo;
            WizardTest.UsarHechizoparaDefensa("cataplumba");
            Assert.AreEqual(defensaDespuesdeHechizo, WizardTest.Defensa);
        }

        [Test]
        // Pruebo si al grabar dos hechizos, se almacena correctamente la defensa del segundo
        public void Hechizosnuevos_defender2_Hechizosdistintos_2()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            int dañoDeHechizo2 = 2233;
            int defensaDeHechizo2 = 1234;
            WizardTest.AprenderHechizo("cataplumba",dañoDeHechizo,defensaDeHechizo);
            WizardTest.AprenderHechizo("Silantro",dañoDeHechizo2,defensaDeHechizo2);
            int defensaDespuesdeHechizo = WizardTest.Defensa + defensaDeHechizo2;
            WizardTest.UsarHechizoparaDefensa("Silantro");
            Assert.AreEqual(defensaDespuesdeHechizo, WizardTest.Defensa);
        }

        [Test]
        // Pruebo si al utilizar dos veces el mismo hechizo de forma defensiva, incrementa correctamente la defensa
        public void AtacarConElMismoHechizo2Veces()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            WizardTest.AprenderHechizo("cataplumba",dañoDeHechizo,defensaDeHechizo);
            int defensaDespuesdeHechizo = WizardTest.Defensa + defensaDeHechizo*2;
            WizardTest.UsarHechizoparaDefensa("cataplumba");
            WizardTest.UsarHechizoparaDefensa("cataplumba");
            Assert.AreEqual(defensaDespuesdeHechizo, WizardTest.Defensa);
        }

        [Test]
        // Pruebo atacar al elfo con un hechizo
        public void AtacarAElfo()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            WizardTest.AprenderHechizo("ataplumbac",dañoDeHechizo,defensaDeHechizo);
            int dañoEsperado = 0;
            int dañoDePoder = WizardTest.UsarHechizoparaAtaque("ataplumbac");
            if ((dañoDePoder - elfoTest.Defensa) > 0)
                dañoEsperado = dañoDePoder - elfoTest.Defensa;
            int vidaDespuesAtaque = elfoTest.VidaActual - dañoEsperado;
            AtaquesconHechizo.AtaqueaElfo(WizardTest,"ataplumbac",elfoTest);
            Assert.AreEqual(vidaDespuesAtaque, elfoTest.VidaActual);
        }

        [Test]
        // Pruebo atacar al enano con un hechizo
        public void AtacarAEnano()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            WizardTest.AprenderHechizo("ataplumbac",dañoDeHechizo,defensaDeHechizo);
            int dañoEsperado = 0;
            int dañoDePoder = WizardTest.UsarHechizoparaAtaque("ataplumbac");
            if ((dañoDePoder - enanoTest.Defensa) > 0)
                dañoEsperado = dañoDePoder - enanoTest.Defensa;
            int vidaDespuesAtaque = enanoTest.VidaActual - dañoEsperado;
            AtaquesconHechizo.AtaqueaEnano(WizardTest,"ataplumbac",enanoTest);
            Assert.AreEqual(vidaDespuesAtaque, enanoTest.VidaActual);
        }

        [Test]
        // Pruebo atacar al humano con un hechizo
        public void AtacarAHumano()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            WizardTest.AprenderHechizo("ataplumbac",dañoDeHechizo,defensaDeHechizo);
            int dañoEsperado = 0;
            int dañoDePoder = WizardTest.UsarHechizoparaAtaque("ataplumbac");
            if ((dañoDePoder - humanoTest.Defensa) > 0)
                dañoEsperado = dañoDePoder - humanoTest.Defensa;
            int vidaDespuesAtaque = humanoTest.VidaActual - dañoEsperado;
            AtaquesconHechizo.AtaqueaHumano(WizardTest,"ataplumbac",humanoTest);
            Assert.AreEqual(vidaDespuesAtaque, humanoTest.VidaActual);
        }
        */

    }
}
using NUnit.Framework;
using Roleplay;

namespace Test.Library
{

    [TestFixture]
    public class TestDesequipar
    {
        private Arco arcoTest;
        private Hacha hachaTest;
        private Baculo baculoTest;
        private Botas botasTest;
        private Escudo escudoTest;
        private Espada espadaTest;
        private Grebas grebasTest;
        private Pechera pecheraTest;
        private Yelmo yelmoTest;
        private Elfo elfoTest;
        private Humano humanoTest;
        private Enano enanoTest;
        private Hechicero hechiceroTest;

        [SetUp]
        public void Setup()
        {
            arcoTest = new Arco(100,0);
            hachaTest = new Hacha(100,0);
            baculoTest = new Baculo(100);
            botasTest = new Botas(0,200);
            escudoTest =new Escudo(0,200);
            espadaTest = new Espada(100,200);
            grebasTest = new Grebas(0,200);
            pecheraTest = new Pechera(0,200);
            yelmoTest = new Yelmo(0,200);
            elfoTest = new Elfo("Raul");
            humanoTest = new Humano("Tusam");
            hechiceroTest = new Hechicero("Richy");
            enanoTest = new Enano("Barbablanca");
        }

        // Se prueba la funcion de desequipar; como cada personaje tiene un inventario diferente, se debe probar el metodo desequipar con todos los personajes. A su vez, cada item se almacena en un lugar diferente en el inventario, por lo que tambien hay que testear el cdesequipamiento de los items individualmente.

        [Test]
        // Prueba si una vez equipado un yelmo en elfo, se puede desequipar correctamente
        public void DesequiparElfo0()
        {
            elfoTest.EquiparYelmo(yelmoTest);
            elfoTest.DesequiparYelmo(yelmoTest);
            Assert.AreEqual(0, elfoTest.Equipamiento[0]);
        }

        [Test]
        // Prueba si una vez equipada una pechera en elfo, se puede desequipar correctamente
        public void DesequiparElfo1()
        {
            elfoTest.EquiparPechera(pecheraTest);
            elfoTest.DesequiparPechera(pecheraTest);
            Assert.AreEqual(1, elfoTest.Equipamiento[1]);
        }

        [Test]
        // Prueba si una vez equipadas las grebas en elfo, se pueden desequipar correctamente
        public void DesequiparElfo2()
        {
            elfoTest.EquiparGrebas(grebasTest);
            elfoTest.DesequiparGrebas(grebasTest);
            Assert.AreEqual(2, elfoTest.Equipamiento[2]);
        }

        [Test]
        // Prueba si una vez equipadas las botas en elfo, se pueden desequipar correctamente
        public void DesequiparElfo3()
        {
            elfoTest.EquiparBotas(botasTest);
            elfoTest.DesequiparBotas(botasTest);
            Assert.AreEqual(3, elfoTest.Equipamiento[3]);
        }

        [Test]
        // Prueba si una vez equipada una espada en elfo, se puede desequipar correctamente
        public void DesequiparElfo4()
        {
            elfoTest.EquiparEspada(espadaTest);
            elfoTest.DesequiparEspada(espadaTest);
            Assert.AreEqual(4, elfoTest.Equipamiento[4]);
        }

        [Test]
        // Prueba si una vez equipado un arco en elfo, se puede desequipar correctamente
        public void DesequiparElfo5()
        {
            elfoTest.EquiparArco(arcoTest);
            elfoTest.DesequiparArco(arcoTest);
            Assert.AreEqual(5, elfoTest.Equipamiento[5]);
        }


        [Test]
        // Prueba si una vez equipado un yelmo en enano, se puede desequipar correctamente
        public void DesequiparEnano0()
        {
            enanoTest.EquiparYelmo(yelmoTest);
            enanoTest.DesequiparYelmo(yelmoTest);
            Assert.AreEqual(0, enanoTest.Equipamiento[0]);
        }

        [Test]
        // Prueba si una vez equipado una pechera en enano, se puede desequipar correctamente
        public void DesequiparEnano1()
        {
            enanoTest.EquiparPechera(pecheraTest);
            enanoTest.DesequiparPechera(pecheraTest);
            Assert.AreEqual(1, enanoTest.Equipamiento[1]);
        }

        [Test]
        // Prueba si una vez equipadas las grebas en enano, se pueden desequipar correctamente
        public void DesequiparEnano2()
        {
            enanoTest.EquiparGrebas(grebasTest);
            enanoTest.DesequiparGrebas(grebasTest);
            Assert.AreEqual(2, enanoTest.Equipamiento[2]);
        }

        [Test]
        public void DesequiparEnano3()
        // Prueba si una vez equipadas las botas en enano, se pueden desequipar correctamente
        {
            enanoTest.EquiparBotas(botasTest);
            enanoTest.DesequiparBotas(botasTest);
            Assert.AreEqual(3, enanoTest.Equipamiento[3]);
        }

        [Test]
        // Prueba si una vez equipada una espada en enano, se puede desequipar correctamente
        public void DesequiparEnano4()
        {
            enanoTest.EquiparEspada(espadaTest);
            enanoTest.DesequiparEspada(espadaTest);
            Assert.AreEqual(4, enanoTest.Equipamiento[4]);
        }

        [Test]
        // Prueba si una vez equipado un hacha en enano, se puede desequipar correctamente
        public void DesequiparEnano5()
        {
            enanoTest.EquiparHacha(hachaTest);
            enanoTest.DesequiparHacha(hachaTest);
            Assert.AreEqual(5, enanoTest.Equipamiento[5]);
        }


        [Test]
        // Prueba si una vez equipado un yelmo en humano, se puede desequipar correctamente
        public void DesequiparHumano0()
        {
            humanoTest.EquiparYelmo(yelmoTest);
            humanoTest.DesequiparYelmo(yelmoTest);
            Assert.AreEqual(0, humanoTest.Equipamiento[0]);
        }

        [Test]
        // Prueba si una vez equipada una pechera en humano, se puede desequipar correctamente
        public void DesequiparHumano1()
        {
            humanoTest.EquiparPechera(pecheraTest);
            humanoTest.DesequiparPechera(pecheraTest);
            Assert.AreEqual(1, humanoTest.Equipamiento[1]);
        }

        [Test]
        // Prueba si una vez equipadas las grebas en humano, se pueden desequipar correctamente
        public void DesequiparHumano2()
        {
            humanoTest.EquiparGrebas(grebasTest);
            humanoTest.DesequiparGrebas(grebasTest);
            Assert.AreEqual(2, humanoTest.Equipamiento[2]);
        }


        [Test]
        // Prueba si una vez equipadas las botas en humano, se pueden desequipar correctamente
        public void DesequiparHumano3()
        {
            humanoTest.EquiparBotas(botasTest);
            humanoTest.DesequiparBotas(botasTest);
            Assert.AreEqual(3, humanoTest.Equipamiento[3]);
        }

        [Test]
        // Prueba si una vez equipada una espada en humano, se puede desequipar correctamente
        public void DesequiparHumano4()
        {
            humanoTest.EquiparEspada(espadaTest);
            humanoTest.DesequiparEspada(espadaTest);
            Assert.AreEqual(4, humanoTest.Equipamiento[4]);
        }

        [Test]
        // Prueba si una vez equipado un escudo en humano, se puede desequipar correctamente
        public void DesequiparHumano5()
        {
            humanoTest.EquiparEscudo(escudoTest);
            humanoTest.DesequiparEscudo(escudoTest);
            Assert.AreEqual(5, humanoTest.Equipamiento[5]);
        }


        [Test]
        // Prueba si una vez equipado un yelmo en hechicero, se puede desequipar correctamente
        public void DesequiparHechicero0()
        {
            hechiceroTest.EquiparYelmo(yelmoTest);
            hechiceroTest.DesequiparYelmo(yelmoTest);
            Assert.AreEqual(0, hechiceroTest.Equipamiento[0]);
        }

        [Test]
        // Prueba si una vez equipada una pechera en hechicero, se puede desequipar correctamente
        public void DesequiparHechicero1()
        {
            hechiceroTest.EquiparPechera(pecheraTest);
            hechiceroTest.DesequiparPechera(pecheraTest);
            Assert.AreEqual(1, hechiceroTest.Equipamiento[1]);
        }

        [Test]
        // Prueba si una vez equipadas las grebas en hechicero, se pueden desequipar correctamente
        public void DesequiparHechicero2()
        {
            hechiceroTest.EquiparGrebas(grebasTest);
            hechiceroTest.DesequiparGrebas(grebasTest);
            Assert.AreEqual(2, hechiceroTest.Equipamiento[2]);
        }

        [Test]
        // Prueba si una vez equipadas las botas en hechicero, se pueden desequipar correctamente
        public void DesequiparHechicero3()
        {
            hechiceroTest.EquiparBotas(botasTest);
            hechiceroTest.DesequiparBotas(botasTest);
            Assert.AreEqual(3, hechiceroTest.Equipamiento[3]);
        }

        [Test]
        // Prueba si una vez equipado un baculo en hechicero, se puede desequipar correctamente
        public void DesequiparHechicero4()
        {
            hechiceroTest.EquiparBaculo(baculoTest);
            hechiceroTest.DesequiparBaculo(baculoTest);
            Assert.AreEqual(4, hechiceroTest.Equipamiento[4]);
        }
    }
}

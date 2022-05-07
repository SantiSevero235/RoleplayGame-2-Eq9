using NUnit.Framework;
using Roleplay;

namespace Test.Library
{

    [TestFixture]
    public class TestEquipar
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
            enanoTest = new Enano("Yoda");
        }

        // Se prueba la funcion de equipar; como cada personaje tiene un inventario diferente, se debe probar el metodo equipar con todos los personajes. A su vez, cada item se almacena en un lugar diferente en el inventario, por lo que tambien hay que testear el equipamiento de los items individualmente.

        [Test]
        // Prueba equipar un yelmo en elfo, aunque tenga otro equipado
        public void equiparElfo0()
        {
            elfoTest.EquiparYelmo(yelmoTest);
            Yelmo yelmoTest2 = new Yelmo(0, 400);
            elfoTest.EquiparYelmo(yelmoTest2);
            Yelmo expected = yelmoTest;
            Assert.AreEqual(expected, elfoTest.Equipamiento[0]);
        }
        
        [Test]
        // Prueba equipar una pechera en elfo, aunque tenga otra equipada
        public void equiparElfo1()
        {
            elfoTest.EquiparPechera(pecheraTest);
            Pechera pecheraTest2 = new Pechera(0, 400);
            elfoTest.EquiparPechera(pecheraTest2);
            Pechera expected = pecheraTest;
            Assert.AreEqual(expected, elfoTest.Equipamiento[1]);
        }

        [Test]
        // Prueba equipar las grebas en elfo, aunque tenga otras equipadas
        public void equiparElfo2()
        {
            elfoTest.EquiparGrebas(grebasTest);
            Grebas grebasTest2 = new Grebas(0, 400);
            elfoTest.EquiparGrebas(grebasTest2);
            Grebas expected = grebasTest;
            Assert.AreEqual(expected, elfoTest.Equipamiento[2]);
        }

        [Test]
        // Prueba equipar las botas en elfo, aunque tenga otras equipadas
        public void equiparElfo3()
        {
            elfoTest.EquiparBotas(botasTest);
            Botas botasTest2 = new Botas(0,400);
            elfoTest.EquiparBotas(botasTest2);
            Botas expected = botasTest;
            Assert.AreEqual(expected, elfoTest.Equipamiento[3]);
        }

        [Test]
        // Prueba equipar una espada en elfo, aunque tenga otra equipada
        public void equiparElfo4()
        {
            elfoTest.EquiparEspada(espadaTest);
            Espada espadaTest2 = new Espada(100,200);
            elfoTest.EquiparEspada(espadaTest2);
            Espada expected = espadaTest;
            Assert.AreEqual(expected, elfoTest.Equipamiento[4]);
        }

        [Test]
        // Prueba equipar una arco en elfo, aunque tenga otra equipada
        public void equiparElfo5()
        {
            elfoTest.EquiparArco(arcoTest);
            Arco arcoTest2 = new Arco(100,200);
            elfoTest.EquiparArco(arcoTest2);
            Arco expected = arcoTest;
            Assert.AreEqual(expected, elfoTest.Equipamiento[5]);
        }

        [Test]
        // Prueba equipar un yelmo en enano, aunque tenga otro equipado
        public void equiparEnano0()
        {
            enanoTest.EquiparYelmo(yelmoTest);
            Yelmo yelmoTest2 = new Yelmo(0, 400);
            enanoTest.EquiparYelmo(yelmoTest2);
            Yelmo expected = yelmoTest;
            Assert.AreEqual(expected, enanoTest.Equipamiento[0]);
        }

        [Test]
        // Prueba equipar una pechera en enano, aunque tenga otra equipada
        public void equiparEnano1()
        {
            enanoTest.EquiparPechera(pecheraTest);
            Pechera pecheraTest2 = new Pechera(0, 400);
            enanoTest.EquiparPechera(pecheraTest2);
            Pechera expected = pecheraTest;
            Assert.AreEqual(expected, enanoTest.Equipamiento[1]);
        }

        [Test]
        // Prueba equipar las grebas en enano, aunque tenga otras equipadas
        public void equiparEnano2()
        {
            enanoTest.EquiparGrebas(grebasTest);
            Grebas grebasTest2 = new Grebas(0, 400);
            enanoTest.EquiparGrebas(grebasTest2);
            Grebas expected = grebasTest;
            Assert.AreEqual(expected, enanoTest.Equipamiento[2]);
        }

        [Test]
        // Prueba equipar unas botas en enano, aunque tenga otras equipadas
        public void equiparEnano3()
        {
            enanoTest.EquiparBotas(botasTest);
            Botas botasTest2 = new Botas(0,400);
            enanoTest.EquiparBotas(botasTest2);
            Botas expected = botasTest;
            Assert.AreEqual(expected, enanoTest.Equipamiento[3]);
        }

        [Test]
        // Prueba equipar una espada en enano, aunque tenga otra equipada
        public void equiparEnano4()
        {
            enanoTest.EquiparEspada(espadaTest);
            Espada espadaTest2 = new Espada(100,200);
            enanoTest.EquiparEspada(espadaTest2);
            Espada expected = espadaTest;
            Assert.AreEqual(expected, enanoTest.Equipamiento[4]);
        }

        [Test]
        // Prueba equipar un hacha en enano, aunque tenga otra equipada
        public void equiparEnano5()
        {
            enanoTest.EquiparHacha(hachaTest);
            Hacha hachaTest2 = new Hacha(100,200);
            enanoTest.EquiparHacha(hachaTest2);
            Hacha expected = hachaTest;
            Assert.AreEqual(expected, enanoTest.Equipamiento[5]);
        }

        [Test]
        // Prueba equipar un yelmo en humano, aunque tenga otro equipao
        public void equiparHumano0()
        {
            humanoTest.EquiparYelmo(yelmoTest);
            Yelmo yelmoTest2 = new Yelmo(0, 400);
            humanoTest.EquiparYelmo(yelmoTest2);
            Yelmo expected = yelmoTest;
            Assert.AreEqual(expected, humanoTest.Equipamiento[0]);
        }

        [Test]
        // Prueba equipar una pechera en humano, aunque tenga otra equipada
        public void equiparHumano1()
        {
            humanoTest.EquiparPechera(pecheraTest);
            Pechera pecheraTest2 = new Pechera(0, 400);
            humanoTest.EquiparPechera(pecheraTest2);
            Pechera expected = pecheraTest;
            Assert.AreEqual(expected, humanoTest.Equipamiento[1]);
        }

        [Test]
        // Prueba equipar unas grebas en humano, aunque tenga otras equipadas
        public void equiparHumano2()
        {
            humanoTest.EquiparGrebas(grebasTest);
            Grebas grebasTest2 = new Grebas(0, 400);
            humanoTest.EquiparGrebas(grebasTest2);
            Grebas expected = grebasTest;
            Assert.AreEqual(expected, humanoTest.Equipamiento[2]);
        }

        [Test]
        // Prueba equipar unas botas en humano, aunque tenga otras equipadas
        public void equiparHumano3()
        {
            humanoTest.EquiparBotas(botasTest);
            Botas botasTest2 = new Botas(0,400);
            humanoTest.EquiparBotas(botasTest2);
            Botas expected = botasTest;
            Assert.AreEqual(expected, humanoTest.Equipamiento[3]);
        }

        [Test]
        // Prueba equipar una espada en humano, aunque tenga otra equipada
        public void equiparHumano4()
        {
            humanoTest.EquiparEspada(espadaTest);
            Espada espadaTest2 = new Espada(100,200);
            humanoTest.EquiparEspada(espadaTest2);
            Espada expected = espadaTest;
            Assert.AreEqual(expected, humanoTest.Equipamiento[4]);
        }

        [Test]
        // Prueba equipar un escudo en humano, aunque tenga otro equipado
        public void equiparHumano5()
        {
            humanoTest.EquiparEscudo(escudoTest);
            Escudo escudoTest2 = new Escudo(100,200);
            humanoTest.EquiparEscudo(escudoTest2);
            Escudo expected = escudoTest;
            Assert.AreEqual(expected, humanoTest.Equipamiento[5]);
        }

        [Test]
        // Prueba equipar un yelmo en hechicero, aunque tenga otro equipado
        public void equiparHechicero0()
        {
            hechiceroTest.EquiparYelmo(yelmoTest);
            Yelmo yelmoTest2 = new Yelmo(0, 400);
            hechiceroTest.EquiparYelmo(yelmoTest2);
            Yelmo expected = yelmoTest;
            Assert.AreEqual(expected, hechiceroTest.Equipamiento[0]);
        }

        [Test]
        // Prueba equipar una pechera en hechicero, aunque tenga otra equipada
        public void equiparHechicero1()
        {
            hechiceroTest.EquiparPechera(pecheraTest);
            Pechera pecheraTest2 = new Pechera(0, 400);
            hechiceroTest.EquiparPechera(pecheraTest2);
            Pechera expected = pecheraTest;
            Assert.AreEqual(expected, hechiceroTest.Equipamiento[1]);
        }

        [Test]
        // Prueba equipar unas grebas en hechicero, aunque tenga otras equipadas
        public void equiparHechicero2()
        {
            hechiceroTest.EquiparGrebas(grebasTest);
            Grebas grebasTest2 = new Grebas(0, 400);
            hechiceroTest.EquiparGrebas(grebasTest2);
            Grebas expected = grebasTest;
            Assert.AreEqual(expected, hechiceroTest.Equipamiento[2]);
        }

        [Test]
        // Prueba equipar unas botas en hechicero, aunque tenga otras equipadas
        public void equiparHechicero3()
        {
            hechiceroTest.EquiparBotas(botasTest);
            Botas botasTest2 = new Botas(0,400);
            hechiceroTest.EquiparBotas(botasTest2);
            Botas expected = botasTest;
            Assert.AreEqual(expected, hechiceroTest.Equipamiento[3]);
        }

        [Test]
        // Prueba equipar un baculo en hechicero, aunque tenga otro equipado
        public void equiparHechicero4()
        {
            hechiceroTest.EquiparBaculo(baculoTest);
            Baculo baculoTest2 = new Baculo(100);
            hechiceroTest.EquiparBaculo(baculoTest2);
            Baculo expected = baculoTest;
            Assert.AreEqual(expected, hechiceroTest.Equipamiento[4]);
        }
    }
}

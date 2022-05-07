/*using NUnit.Framework;
using System;
using Roleplay;


namespace Test.Library
{

    [TestFixture]
    public class Example
    {
        private Arco arcoTest;
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
        private Hechicero hechiceroTest2;
        [SetUp]
        public void Setup()
        {
            arcoTest = new Arco(100,0);
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
            hechiceroTest2 = new Hechicero("Pablo");
            enanoTest = new Enano("Malboro");
        }
        [Test]
        /// <summary>
        /// Pruebo el hechizo inicial con el que se crean los magos y ademas si funciona
        /// el ataque entre magos
        /// </summary>
        public void HechizoInicial()
        {
            int dañoEsperado = 0;
            int dañoDeHechizo = hechiceroTest.UsarHechizoparaAtaque("Hechizo inicial");
            if ((dañoDeHechizo - hechiceroTest2.Defensa) > 0)
                dañoEsperado = dañoDeHechizo - hechiceroTest2.Defensa;
            int vidaDespuesAtaque = hechiceroTest2.VidaActual - dañoEsperado;
            AtaquesconHechizo.AtaqueaHechicero(hechiceroTest,"Hechizo inicial",hechiceroTest2);
            Assert.AreEqual(vidaDespuesAtaque, hechiceroTest2.VidaActual);
        }

        [Test]
        /// <summary>
        /// Pruebo crear un hechizo y ver si su daño se graba correctamente y se utiliza luego al atacar.
        /// </summary>
        public void Hechizonuevo_daño()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            hechiceroTest.AprenderHechizo("cataplumba",dañoDeHechizo,defensaDeHechizo);
            int dañoEsperado = 0;
            int dañoporHechizo = hechiceroTest.UsarHechizoparaAtaque("cataplumba");

            if ((dañoporHechizo - hechiceroTest2.Defensa) > 0)
                dañoEsperado = dañoporHechizo - hechiceroTest2.Defensa;
            int vidaDespuesAtaque = hechiceroTest2.VidaActual - dañoEsperado;
            AtaquesconHechizo.AtaqueaHechicero(hechiceroTest,"cataplumba",hechiceroTest2);
            Assert.AreEqual(vidaDespuesAtaque, hechiceroTest2.VidaActual);          

        }
        
        [Test]
        // Prueba si se aumenta correctamente la defensa al utilizar un hechizo creado
        public void Hechizonuevo_defender()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            hechiceroTest.AprenderHechizo("cataplumba",dañoDeHechizo,defensaDeHechizo);
            int defensaDespuesdeHechizo = hechiceroTest.Defensa + defensaDeHechizo;
            hechiceroTest.UsarHechizoparaDefensa("cataplumba");
            Assert.AreEqual(defensaDespuesdeHechizo, hechiceroTest.Defensa);
        }
        
        [Test]
        // Pruebo si cuando se crean dos hechizos iguales y se intentan añadir al libro de hechizos, se mantiene el primero con su atributo defensa intacto
        public void Hechizosnuevos_defender2()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            int dañoDeHechizo2 = 2233;
            int defensaDeHechizo2 = 1234;
            hechiceroTest.AprenderHechizo("cataplumba",dañoDeHechizo,defensaDeHechizo);
            hechiceroTest.AprenderHechizo("cataplumba",dañoDeHechizo2,defensaDeHechizo2);
            int defensaDespuesdeHechizo = hechiceroTest.Defensa + defensaDeHechizo;
            hechiceroTest.UsarHechizoparaDefensa("cataplumba");
            Assert.AreEqual(defensaDespuesdeHechizo, hechiceroTest.Defensa);
        }

        [Test]
        // Pruebo si cuando se crean dos hechizos iguales y se intentan añadir al libro de hechizos, se mantiene el primero con su atributo daño intacto
        public void Hechizonuevos_daño()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            int dañoDeHechizo2 = 2212;
            int defensaDeHechizo2 = 1233;
            hechiceroTest.AprenderHechizo("cataplumba",dañoDeHechizo,defensaDeHechizo);
            hechiceroTest.AprenderHechizo("cataplumba",dañoDeHechizo2,defensaDeHechizo2);
            int dañoEsperado = 0;
            int dañoporHechizo = hechiceroTest.UsarHechizoparaAtaque("cataplumba");

            if ((dañoporHechizo - hechiceroTest2.Defensa) > 0)
                dañoEsperado = dañoporHechizo - hechiceroTest2.Defensa;
            int vidaDespuesAtaque = hechiceroTest2.VidaActual - dañoEsperado;
            AtaquesconHechizo.AtaqueaHechicero(hechiceroTest,"cataplumba",hechiceroTest2);
            Assert.AreEqual(vidaDespuesAtaque, hechiceroTest2.VidaActual);          
        }

        [Test]
        // Pruebo si al grabar dos hechizos, se almacena correctamente la defensa del primero
        public void Hechizosnuevos_defender2_Hechizosdistintos_1()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            int dañoDeHechizo2 = 2233;
            int defensaDeHechizo2 = 1234;
            hechiceroTest.AprenderHechizo("cataplumba",dañoDeHechizo,defensaDeHechizo);
            hechiceroTest.AprenderHechizo("Silantro",dañoDeHechizo2,defensaDeHechizo2);
            int defensaDespuesdeHechizo = hechiceroTest.Defensa + defensaDeHechizo;
            hechiceroTest.UsarHechizoparaDefensa("cataplumba");
            Assert.AreEqual(defensaDespuesdeHechizo, hechiceroTest.Defensa);
        }

        [Test]
        // Pruebo si al grabar dos hechizos, se almacena correctamente la defensa del segundo
        public void Hechizosnuevos_defender2_Hechizosdistintos_2()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            int dañoDeHechizo2 = 2233;
            int defensaDeHechizo2 = 1234;
            hechiceroTest.AprenderHechizo("cataplumba",dañoDeHechizo,defensaDeHechizo);
            hechiceroTest.AprenderHechizo("Silantro",dañoDeHechizo2,defensaDeHechizo2);
            int defensaDespuesdeHechizo = hechiceroTest.Defensa + defensaDeHechizo2;
            hechiceroTest.UsarHechizoparaDefensa("Silantro");
            Assert.AreEqual(defensaDespuesdeHechizo, hechiceroTest.Defensa);
        }

        [Test]
        // Pruebo si al utilizar dos veces el mismo hechizo de forma defensiva, incrementa correctamente la defensa
        public void AtacarConElMismoHechizo2Veces()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            hechiceroTest.AprenderHechizo("cataplumba",dañoDeHechizo,defensaDeHechizo);
            int defensaDespuesdeHechizo = hechiceroTest.Defensa + defensaDeHechizo*2;
            hechiceroTest.UsarHechizoparaDefensa("cataplumba");
            hechiceroTest.UsarHechizoparaDefensa("cataplumba");
            Assert.AreEqual(defensaDespuesdeHechizo, hechiceroTest.Defensa);
        }

        [Test]
        // Pruebo atacar al elfo con un hechizo
        public void AtacarAElfo()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            hechiceroTest.AprenderHechizo("ataplumbac",dañoDeHechizo,defensaDeHechizo);
            int dañoEsperado = 0;
            int dañoDePoder = hechiceroTest.UsarHechizoparaAtaque("ataplumbac");
            if ((dañoDePoder - elfoTest.Defensa) > 0)
                dañoEsperado = dañoDePoder - elfoTest.Defensa;
            int vidaDespuesAtaque = elfoTest.VidaActual - dañoEsperado;
            AtaquesconHechizo.AtaqueaElfo(hechiceroTest,"ataplumbac",elfoTest);
            Assert.AreEqual(vidaDespuesAtaque, elfoTest.VidaActual);
        }

        [Test]
        // Pruebo atacar al enano con un hechizo
        public void AtacarAEnano()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            hechiceroTest.AprenderHechizo("ataplumbac",dañoDeHechizo,defensaDeHechizo);
            int dañoEsperado = 0;
            int dañoDePoder = hechiceroTest.UsarHechizoparaAtaque("ataplumbac");
            if ((dañoDePoder - enanoTest.Defensa) > 0)
                dañoEsperado = dañoDePoder - enanoTest.Defensa;
            int vidaDespuesAtaque = enanoTest.VidaActual - dañoEsperado;
            AtaquesconHechizo.AtaqueaEnano(hechiceroTest,"ataplumbac",enanoTest);
            Assert.AreEqual(vidaDespuesAtaque, enanoTest.VidaActual);
        }

        [Test]
        // Pruebo atacar al humano con un hechizo
        public void AtacarAHumano()
        {
            int dañoDeHechizo = 221;
            int defensaDeHechizo = 123;
            hechiceroTest.AprenderHechizo("ataplumbac",dañoDeHechizo,defensaDeHechizo);
            int dañoEsperado = 0;
            int dañoDePoder = hechiceroTest.UsarHechizoparaAtaque("ataplumbac");
            if ((dañoDePoder - humanoTest.Defensa) > 0)
                dañoEsperado = dañoDePoder - humanoTest.Defensa;
            int vidaDespuesAtaque = humanoTest.VidaActual - dañoEsperado;
            AtaquesconHechizo.AtaqueaHumano(hechiceroTest,"ataplumbac",humanoTest);
            Assert.AreEqual(vidaDespuesAtaque, humanoTest.VidaActual);
        }
        

    }
}*/
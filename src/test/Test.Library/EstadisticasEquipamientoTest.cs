using NUnit.Framework;
using Roleplay;

namespace Test.Library
{


    public class TestsItems
    {

        // Comprueba que se asignen de manera correcta los daños y las defensas de los items.

        [Test]
        // Comprueba que se asigne de manera correcta el poder del baculo
        public void poderBaculo()
        {
            Baculo baculo = new Baculo(100);
            int poderBaculo = baculo.Poder;
            int expected = 100;
            Assert.AreEqual(expected, poderBaculo);
        }

        [Test]
        // Comprueba que se asigne de manera correcta el daño del arco
        public void dañoArco()
        {
            Arco arco = new Arco(100, 0);
            int dañoArco = arco.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoArco);
        }

        [Test]
        // Comprueba que se asigne de manera correcta la defensa del arco
        public void defensaArco()
        {
            Arco arco = new Arco(100, 0);
            int defensaArco = arco.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaArco);
        }

        [Test]
        // Comprueba que se asigne de manera correcta el daño de la espada
        public void dañoEspada()
        {
            Espada espada = new Espada(100, 0);
            int dañoEspada = espada.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoEspada);
        }

        [Test]
        // Comprueba que se asigne de manera correcta la defensa de la espada
        public void defensaEspada()
        {
            Espada espada = new Espada(100, 0);
            int defensaEspada = espada.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaEspada);
        }

        [Test]
        // Comprueba que se asigne de manera correcta el daño de las botas
        public void dañoBotas()
        {
            Botas botas = new Botas(100, 0);
            int dañoBotas = botas.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoBotas);
        }

        [Test]
        // Comprueba que se asigne de manera correcta la defensa de las botas
        public void defensaBotas()
        {
            Botas botas = new Botas(100, 0);
            int defensaBotas = botas.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaBotas);
        }

        [Test]
        // Comprueba que se asigne de manera correcta el daño del escudo
        public void dañoEscudo()
        {
            Escudo escudo = new Escudo(100, 0);
            int dañoEscudo = escudo.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoEscudo);
        }
        
        [Test]
        // Comprueba que se asigne de manera correcta la defensa del escudo
        public void defensaEscudo()
        {
            Escudo escudo = new Escudo(100, 0);
            int defensaEscudo = escudo.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaEscudo);
        }

        [Test]
        // Comprueba que se asigne de manera correcta el daño de las grebas
        public void dañoGrebas()
        {
            Grebas grebas = new Grebas(100, 0);
            int dañoGrebas = grebas.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoGrebas);
        }
        
        [Test]
        // Comprueba que se asigne de manera correcta la defensa de las grebas
        public void defensaGrebas()
        {
            Grebas grebas = new Grebas(100, 0);
            int defensaGrebas = grebas.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaGrebas);
        }

        [Test]
        // Comprueba que se asigne de manera correcta el daño del hacha
        public void dañoHacha()
        {
            Hacha hacha = new Hacha(100, 0);
            int dañoHacha = hacha.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoHacha);
        }
        
        [Test]
        // Comprueba que se asigne de manera correcta la defensa del hacha
        public void defensaHacha()
        {
            Hacha hacha = new Hacha(100, 0);
            int defensaHacha = hacha.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaHacha);
        }

        [Test]
        // Comprueba que se asigne de manera correcta el daño de la pechera
        public void dañoPechera()
        {
            Pechera pechera = new Pechera(100, 0);
            int dañoPechera = pechera.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoPechera);
        }
        
        [Test]
        // Comprueba que se asigne de manera correcta la defensa de la pechera
        public void defensaPechera()
        {
            Pechera pechera = new Pechera(100, 0);
            int defensaPechera = pechera.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaPechera);
        }

        [Test]
        // Comprueba que se asigne de manera correcta el daño del yelmo
        public void dañoYelmo()
        {
            Yelmo yelmo = new Yelmo(100, 0);
            int dañoYelmo = yelmo.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoYelmo);
        }
        
        [Test]
        // Comprueba que se asigne de manera correcta la defensa del yelmo
        public void defensaYelmo()
        {
            Yelmo yelmo = new Yelmo(100, 0);
            int defensaYelmo = yelmo.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaYelmo);
        }

        [Test]
        // Comprueba que se asigne de manera correcta el nombre del hechizo
        public void nombreHechizo()
        {
            Hechizo hechizo = new Hechizo("Bola de fuego", 100, 0);
            string nombreHechizo = hechizo.Nombre;
            string expected = "Bola de fuego";
            Assert.AreEqual(expected, nombreHechizo);
        }

        [Test]
        // Comprueba que se asigne de manera correcta el nombre del hechizo (cuando es vacio)
        public void nombreHechizo2()
        {
            Hechizo hechizo = new Hechizo("", 100, 0);
            string dañoHechizo = hechizo.Nombre;
            string expected = "";
            Assert.AreEqual(expected, dañoHechizo);
        }

        [Test]
        // Comprueba que se asigne de manera correcta el daño del hechizo
        public void dañoHechizo()
        {
            Hechizo hechizo = new Hechizo("Bola de fuego", 100, 0);
            int dañoHechizo = hechizo.Daño;
            int expected = 100;
            Assert.AreEqual(expected, dañoHechizo);
        }
        
        [Test]
        // Comprueba que se asigne de manera correcta la defensa del hechizo
        public void defensaHechizo()
        {
            Hechizo hechizo = new Hechizo("Bola de fuego", 100, 0);
            int defensaHechizo = hechizo.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaHechizo);
        }
    }
}

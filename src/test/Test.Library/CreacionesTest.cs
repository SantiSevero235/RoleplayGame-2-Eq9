/*using NUnit.Framework;


namespace Roleplay
{


    public class SantiTests
    {

        Los Tests se tratan de que coincidan tanto las cosas asignadas, Primero Creamos un personaje/hechizo/ataque, las llamamos a traves de 
        (<variable>.accion), Asignamos un expected, un int o string que se espera que sea con nuestra creación, 
        todas están hechas para que sean todas correctas. Se usa Assert.Equal para hacer la comparación para que coincida.
        
        [Test]
        // Prueba si se asigna correctamente el nombre del hechicero
        public void NameHechicero()
        {
            Hechicero hechicero = new Hechicero("Merlin");
            string nombreHechicero = hechicero.Nombre;
            string expected = "Merlin";
            Assert.AreEqual(expected, nombreHechicero);
        }

        [Test]
        // Prueba si se asigna correctamente el nombre del elfo
        public void NameElfo()
        {
            Elfo elfo = new Elfo("Legolas");
            string nombreElfo = elfo.Nombre;
            string expected = "Legolas";
            Assert.AreEqual(expected, nombreElfo);
        }

        [Test]
        // Prueba si se asigna correctamente el nombre del humano
        public void NameHumano()
        {
            Humano humano = new Humano("Carlos");
            string nombreHumano = humano.Nombre;
            string expected = "Carlos";
            Assert.AreEqual(expected, nombreHumano);
        }

        [Test]
        // Prueba si se asigna correctamente el nombre del enano
        public void NameEnano()
        {
            Enano enano = new Enano("Gigan");
            string nombreEnano = enano.Nombre;
            string expected = "Gigan";
            Assert.AreEqual(expected, nombreEnano);
        }

        
        [Test]
        // Prueba si se asigna correctamente la vida del humano
        public void TestVActualHumano()
        {
            Humano humano = new Humano("Jose");
            int vidabase = humano.VidaActual;
            int expected = 500;
            Assert.AreEqual(expected, vidabase);
        }
        [Test]
        // Prueba si se asigna correctamente la vida del enano
        public void TestVActualEnano()
        {
            Enano enano = new Enano("Ralvol");
            int vidabase = enano.VidaActual;
            int expected = 500;
            Assert.AreEqual(expected, vidabase);
        }

        [Test]
        // Prueba si se asigna correctamente la vida del elfo
        public void TestVActualElfo()
        {
            Elfo elfo = new Elfo("Cirdan");
            int vidabase = elfo.VidaActual;
            int expected = 500;
            Assert.AreEqual(expected, vidabase);
        }

        [Test]
        // Prueba si se asigna correctamente la vida del hechicero
        public void TestVActualHechicero()
        {
            Hechicero hechicero = new Hechicero("Gandalf");
            int vidabase = hechicero.VidaActual;
            int expected = 500;
            Assert.AreEqual(expected, vidabase);
        }

        [Test]
        // Prueba si se asigna correctamente la defensa del hechicero
        public void TestDefensaHechicero()
        {
            Hechicero hechicero = new Hechicero("Harry");
            int defensaHechicero = hechicero.Defensa;
            int expected = 500;
            Assert.AreEqual(expected, defensaHechicero);
        }

        [Test]
        // Prueba si se asigna correctamente la defensa del elfo
        public void TestDefensaElfo()
        {
            Elfo elfo = new Elfo("Legolas");
            int defensaElfo = elfo.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaElfo);
        }

        [Test]
        // Prueba si se asigna correctamente la defensa del enano
        public void TestDefensaEnano()
        {
            Enano enano = new Enano("Bamur");
            int defensaEnano = enano.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaEnano);
        }

        [Test]
        // Prueba si se asigna correctamente la defensa del humano
        public void TestDefensaHumano()
        {
            Humano humano = new Humano("Carlos");
            int defensaHumano = humano.Defensa;
            int expected = 0;
            Assert.AreEqual(expected, defensaHumano);
        }

        [Test]
        // Prueba si se asigna correctamente el ataque de elfo
        public void TestAtaqueElfo()
        {
            Elfo elfo = new Elfo("Link");
            int AtaqueElfo = elfo.Ataque;
            int expected = 500;
            Assert.AreEqual(expected, AtaqueElfo);
        }

        [Test]
        // Prueba si se asigna correctamente el ataque del enano
        public void TestAtaqueEnano()
        {
            Enano enano = new Enano("Rey Mysterio");
            int AtaqueEnano = enano.Ataque;
            int expected = 500;
            Assert.AreEqual(expected, AtaqueEnano);
        }

        [Test]
        // Prueba si se asigna correctamente el ataque del hechicero
        public void TestAtaqueHechicero()
        {
            Hechicero hechicero = new Hechicero("Merlin");
            int AtaqueHechicero = hechicero.Ataque;
            int expected = 500;
            Assert.AreEqual(expected, AtaqueHechicero);
        }

        [Test]
        // Prueba si se asigna correctamente el ataque del humano
        public void TestAtaqueHumano()
        {
            Humano humano = new Humano("Matias");
            int AtaqueHumano = humano.Ataque;
            int expected = 500;
            Assert.AreEqual(expected, AtaqueHumano);
        }
    }


}*/
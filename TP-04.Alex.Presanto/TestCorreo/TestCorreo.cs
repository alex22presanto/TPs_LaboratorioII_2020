using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace TestCorreo
{
    [TestClass]
    public class TestCorreo
    {
        [TestMethod]
        public void ListaDePaqeutesEnCorreo()
        {
            Correo correo = new Correo();

            Assert.IsNotNull(correo.Paquetes);
        }

        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void AgregarPaqueteIgual()
        {
            Correo correo = new Correo();
            Paquete paquete = new Paquete("Prueba1", "1");

            correo += paquete;
            correo += paquete;

        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;


namespace ProyectoDePuebas
{
    [TestClass]
    public class PruebaListas
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange 
            Universidad universidad = new Universidad();
            // assert
            Assert.IsNotNull(universidad.Alumnos);
            Assert.IsNotNull(universidad.Profesores);
            Assert.IsNotNull(universidad.Jornadas);
        }
    }
}

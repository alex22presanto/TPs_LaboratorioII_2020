using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Archivos;
using ClasesInstanciables;
using ClasesAbstractas;

namespace ProyectoDePuebas
{
    [TestClass]
    public class PruebaExcepciones
    {
        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void TestMethod1()
        {
            //arrange
            Texto t = new Texto();
            //act
            t.Guardar("", "asd");
            //assert controlado con ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestMethod2()
        {
            //arrange / act 
            Alumno alumno = new Alumno(1, "Nombre1", "Apellido1", "123as1323", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            //assert controlado con ExpectedException
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace TestEstadisticas
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]

        public void RetornaCero_CuandoElSegundoParametro_EsCero()
        {
            //Arrange
            float parametrodos = 0;

            Alumno alumno = new Alumno();
            float resultadoExperado = 0;

            //Act
            float resultadoReal = alumno.ObtenerPromedio(5, parametrodos);

            Assert.AreEqual(resultadoExperado, resultadoReal);
        }

        [TestMethod]
        public void RetornaCero_CuandoElSegundoParametro_EsNegativo()
        {
            //Arrange
            float parametrodos = -4;

            Alumno alumno = new Alumno();
            float resultadoExperado = 0;

            //Act
            float resultadoReal = alumno.ObtenerPromedio(5, parametrodos);

            Assert.AreEqual(resultadoExperado, resultadoReal);
        }

        [TestMethod]
        public void Retorna4_CuandoElSegundoParametro_EsOcho()
        {
            //Arrange
            float parametrodos = 2;

            Alumno alumno = new Alumno();
            float resultadoExperado = 4;

            //Act
            float resultadoReal = alumno.ObtenerPromedio(8, parametrodos);

            Assert.AreEqual(resultadoExperado, resultadoReal);
        }

    }
}

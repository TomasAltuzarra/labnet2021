using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Practico02.Extensiones;

namespace UnitTesting
{
    [TestClass]
    public class DivTest
    {
        [DataRow(6, 2, 3)]
        [DataRow(0, 2, 0)]

        [TestMethod]
        public void DivisionDeDosInt(int div1, int div2, int esperado)
        {
            //seccion arrage, reemplazada en este test por los data rows
            /*int div1 = 6;
            int div2 = 2;
            int esperado = 3;*/

            //seccion act
            int actual = IntegerExtensions.Dividir(div1, div2);

            //seccion assert
            Assert.AreEqual(actual, esperado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionDeDosCeroException()
        {
            //seccion arrage
            int div1 = 6;
            int div2 = 0;

            //seccion act
            int resultado = IntegerExtensions.Dividir(div1, div2);

            //seccion assert, nada agregado
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practico05.Entities;
using Practico05.Logic;
using System;

namespace Practico05.UnitTest
{
    [TestClass]
    public class UnitTestQuery3
    {
        Consultas consulta = new Consultas();

        [TestMethod]
        public void TestMeQuery3_DevuelveListaNoNula()
        {
            var p = consulta.Query3();
            Assert.IsNotNull(p);
        }

        [TestMethod]
        public void TestMeQuery3_DevuelveListaConStockDistintoCero()
        {
            var p = consulta.Query3();

            foreach (var prod in p)
            {
                Assert.IsTrue(0 != prod.UnitsInStock);
            }
        }

        [TestMethod]
        public void TestMeQuery3_DevuelveListaConPreciosUnitariosMayorA3()
        {
            var p = consulta.Query3();

            foreach (var prod in p)
            {
                Assert.IsTrue(3 < prod.UnitPrice);
            }
        }
    }
}

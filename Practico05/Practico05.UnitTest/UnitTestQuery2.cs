using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practico05.Entities;
using Practico05.Logic;
using System;

namespace Practico05.UnitTest
{
    [TestClass]
    public class UnitTestQuery2
    {
        Consultas consulta = new Consultas();

        [TestMethod]
        public void TestMeQuery2_DevuelveListaNoNula()
        {
            var p = consulta.Query2();
            Assert.IsNotNull(p);
        }

        [TestMethod]
        public void TestMeQuery2_DevuelveListaConStockIgualCero()
        {
            var p = consulta.Query2();

            foreach (var prod in p)
            {
                Assert.AreEqual(Convert.ToInt16(0), prod.UnitsInStock); //la cantidad de stock es un smallint (int16) en la db
            }
        }
    }
}

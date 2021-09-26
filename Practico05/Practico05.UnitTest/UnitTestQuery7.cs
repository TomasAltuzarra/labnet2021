using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practico05.Entities;
using Practico05.Logic;
using System;

namespace Practico05.UnitTest
{
    [TestClass]
    public class UnitTestQuery7
    {
        Consultas consulta = new Consultas();

        [TestMethod]
        public void TestMeQuery7_DevuelveListaNoNula()
        {
            var l = consulta.Query7();
            Assert.IsNotNull(l);
        }

        [TestMethod]
        public void TestMeQueryBis7_DevuelveRegionWA()
        {
            var lista = consulta.Query7Bis();

            for (int i = 0; i < lista.Count; i++)
            {
                Assert.AreEqual("WA", lista[i]);
            }
        }
    }
}


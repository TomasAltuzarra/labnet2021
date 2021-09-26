using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practico05.Entities;
using Practico05.Logic;
using System;

namespace Practico05.UnitTest
{
    [TestClass]
    public class UnitTestQuery4
    {
        Consultas consulta = new Consultas();

        [TestMethod]
        public void TestMeQuery4_DevuelveListaNoNula()
        {
            var c = consulta.Query4();
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void TestMeQuery4_DevuelveListaConRegionWA()
        {
            var c = consulta.Query4();

            foreach (var cust in c)
            {
                Assert.AreEqual("WA", cust.Region);
            }
        }
    }
}

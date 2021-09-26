using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practico05.Entities;
using Practico05.Logic;
using System;

namespace Practico05.UnitTest
{
    [TestClass]
    public class UnitTestQuery5
    {
        Consultas consulta = new Consultas();

        [TestMethod]
        public void TestMeQuery5_DevuelveIDCorrectaONulo()
        {
            var p = consulta.Query5();

            if (789 != p.ProductID)
            {
                Assert.IsTrue(789 == p.ProductID);
            }
            else 
            {
                Assert.IsTrue(0 == p.ProductID);
                Assert.IsNull(p);
            }
        }
    }
}

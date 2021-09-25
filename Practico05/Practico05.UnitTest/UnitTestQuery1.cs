using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Practico05.Logic;
using Practico05.Entities;

namespace Practico05.UnitTest
{
    [TestClass]
    public class UnitTestQuery1
    {
        Consultas consulta = new Consultas();

        [DataRow("COMMI")]
        [DataRow("CONSH")]

        [TestMethod]
        public void Query1_DevuelveUnElemento(string id)
        {
            Customers c = consulta.Query1(id);
            Assert.IsNotNull(c);
        }

        [DataRow("COMMI")]
        [DataRow("CONSH")]

        [TestMethod]
        public void Query1_DevuelveUnElementoBis(string id)
        {
            Customers c = consulta.Query1(id);
            Assert.AreEqual(id, c.CustomerID);
        }

        [DataRow("TOMYXD")]
        [TestMethod]
        public void Query1_NoEncuentraElemento(string id)
        {
            Customers c = consulta.Query1(id);
            Assert.IsNull(c);
        }

        [TestMethod]
        public void Query1Bis_DevuelveUnElemento()
        {
            Customers c = consulta.Query1Bis();
            Assert.IsNotNull(c);
        }
    }
}

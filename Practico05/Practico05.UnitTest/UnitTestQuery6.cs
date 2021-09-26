using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practico05.Entities;
using Practico05.Logic;
using System;

namespace Practico05.UnitTest
{
    [TestClass]
    public class UnitTestQuery6
    {
        Consultas consulta = new Consultas();

        [TestMethod]
        public void TestMeQuery6_DevuelveListaNoNula()
        {
            var n = consulta.Query6();
            Assert.IsNotNull(n);
        }

        [DataRow("Maria Anders")]
        [DataRow("Francisco Chang")]
        [TestMethod]
        public void TestMeQuery6_DevuelveListaConNombresConcatenados(string nombre)
        {
            var c = consulta.Query6Bis(nombre);

            for (int i = 0; i < c.Count; i++)
            {
                Assert.AreEqual(($"{nombre.ToLower()} - {nombre.ToUpper()}"), c[i]);
            }
        }
    }
}

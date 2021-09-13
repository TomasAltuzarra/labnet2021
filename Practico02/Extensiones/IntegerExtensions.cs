using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico02.Extensiones
{
    public static class IntegerExtensions
    {
        public static int Dividir(this int numero)
        {
            return numero/0;
        }

        public static int Dividir(this int div1, int div2)
        {
            return div1/div2;
        }
    }
}

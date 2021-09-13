using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico02
{
    public class Logic
    {
        public bool? valida;

        public Logic(bool? valida)
        {
            this.valida = null;
        }

        public bool? Validar()
        {
            return valida;
        }
    }
}

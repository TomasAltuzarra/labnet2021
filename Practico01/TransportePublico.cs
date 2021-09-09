using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01
{
    public abstract class TransportePublico
    {
        public int cantidadPasajeros { get; set; }

        public TransportePublico (int cantidadPasajeros)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public abstract void Avanzar();

        public abstract void Detenerse();
    }
}

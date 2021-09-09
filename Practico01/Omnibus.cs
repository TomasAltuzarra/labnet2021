using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01
{
    public class Omnibus : TransportePublico
    {
        public Omnibus (int cantidadPasajeros, int id) : base(cantidadPasajeros,id)
        {

        }
        public override void Avanzar()
        {
            throw new NotImplementedException();
        }

        public override void Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}

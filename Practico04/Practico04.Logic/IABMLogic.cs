using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico04.Logic
{
    interface IABMLogic<A,B>
    {
        List<A> GetAll();
        A GetOne(B codigo);
        void Add(A newAlgo);
        void Delete(B codigo);
        void Update(A newAlgo);
    }
}

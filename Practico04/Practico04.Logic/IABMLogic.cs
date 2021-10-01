using System.Collections.Generic;

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

using Practico04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practico04.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<Employees, int>
    {
        public void Add(Employees newAlgo)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public Employees GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Employees newAlgo)
        {
            throw new NotImplementedException();
        }
    }
}

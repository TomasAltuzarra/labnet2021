using Practico04.Data;
using Practico04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico04.Logic
{
    class EmployeesLogic
    {
        private readonly NorthwindContext context;

        public EmployeesLogic()
        {
            context = new NorthwindContext();
        }

        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }
    }
}

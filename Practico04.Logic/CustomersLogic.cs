using Practico04.Data;
using Practico04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico04.Logic
{
    public class CustomersLogic
    {
        private readonly NorthwindContext context;

        public CustomersLogic()
        {
            context = new NorthwindContext(); 
        }

        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
    }
}

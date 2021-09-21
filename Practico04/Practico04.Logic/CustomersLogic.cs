using Practico04.Data;
using Practico04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico04.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public Customers GetOne(string id)
        {
            return context.Customers.Find(id);
        }

        public void Add(Customers newCustomer)
        {
            context.Customers.Add(newCustomer);
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var customerEliminar = context.Customers.Find(id);
            context.Customers.Remove(customerEliminar);
            context.SaveChanges();
        }

        public void Update(Customers customer)
        {
            var customerUpdate = context.Customers.Find(customer.CustomerID);

            //ver aca los updates
            customerUpdate.ContactName = customer.ContactName;

            context.SaveChanges();
        }
    }
}

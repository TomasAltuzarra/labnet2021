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
            //return context.Customers.First(c => c.CustomerID == id);
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

        public void Update(Customers c)
        {
            var customerUpdate = context.Customers.Find(c.CustomerID);

            customerUpdate.CustomerID = c.CustomerID;
            customerUpdate.CompanyName = c.CompanyName;
            customerUpdate.ContactName = c.ContactName;
            customerUpdate.ContactTitle = c.ContactTitle;
            customerUpdate.Address = c.Address;
            customerUpdate.City = c.City;
            customerUpdate.Region = c.Region;
            customerUpdate.PostalCode = c.PostalCode;
            customerUpdate.Country = c.Country;
            customerUpdate.Phone = c.Phone;
            customerUpdate.Fax = c.Fax;

            context.SaveChanges();
        }
    }
}

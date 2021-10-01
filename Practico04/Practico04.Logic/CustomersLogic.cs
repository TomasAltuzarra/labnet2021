using Practico04.Entities;
using Practico04.Entities.DTO;
using System.Collections.Generic;
using System.Linq;

namespace Practico04.Logic
{
    public class CustomersLogic : BaseLogic , IABMLogic<CustomerDto, string>
    {
        public List<CustomerDto> GetAll()
        {
            var lista = (from c in context.Customers
                    select new CustomerDto()
                    {
                        CustomerID = c.CustomerID,
                        CompanyName = c.CompanyName,
                        ContactName = c.ContactName,
                        ContactTitle = c.ContactTitle,
                        City = c.City,
                        Country = c.Country,
                        Phone = c.Phone
                    }).ToList();
            return lista;
        }

        public CustomerDto GetOne(string id)
        {
            Customers cus = context.Customers.Find(id);
            CustomerDto customer = new CustomerDto
            {
                CustomerID = cus.CustomerID,
                CompanyName = cus.CompanyName,
                ContactName = cus.ContactName,
                ContactTitle = cus.ContactTitle,
                City = cus.City,
                Country = cus.Country,
                Phone = cus.Phone
            };

            return customer;
        }

        public void Add(CustomerDto cus)
        {
            Customers customer = new Customers
            {
                CustomerID = cus.CustomerID,
                CompanyName = cus.CompanyName,
                ContactName = cus.ContactName,
                ContactTitle = cus.ContactTitle,
                City = cus.City,
                Country = cus.Country,
                Phone = cus.Phone
            };

            context.Customers.Add(customer);
            context.SaveChanges();
        }


        public void Delete(string id)
        {
            var customerEliminar = context.Customers.Find(id);
            context.Customers.Remove(customerEliminar);
            context.SaveChanges();
        }

        public void Update(CustomerDto c)
        {
            var customerUpdate = context.Customers.Find(c.CustomerID);

            customerUpdate.CustomerID = c.CustomerID;
            customerUpdate.CompanyName = c.CompanyName;
            customerUpdate.ContactName = c.ContactName;
            customerUpdate.ContactTitle = c.ContactTitle;
            customerUpdate.City = c.City;
            customerUpdate.Country = c.Country;
            customerUpdate.Phone = c.Phone;

            context.SaveChanges();
        }

    }
}

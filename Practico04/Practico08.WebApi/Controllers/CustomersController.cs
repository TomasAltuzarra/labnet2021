using Practico04.Data;
using Practico04.Entities;
using Practico04.Entities.DTO;
using Practico04.Logic;
using Practico07.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
//using System.Web.Mvc;

namespace Practico08.WebApi.Controllers
{
    public class CustomersController : ApiController
    {
        readonly CustomersLogic logic = new CustomersLogic();

        //Get All Customers
        [HttpGet]
        public IEnumerable<CustomerView> GetCustomer()
        {
            List<CustomerDto> customers = logic.GetAll();

            List<CustomerView> customersViews = customers.Select(cus => new CustomerView
            {
                CustomerID = cus.CustomerID,
                CompanyName = cus.CompanyName,
                ContactName = cus.ContactName,
                City = cus.City,
                Country = cus.Country,
                Phone = cus.Phone
            }).ToList();

            return customersViews;
        }

        //Get One Customer
        [HttpGet]
        public CustomerView GetCustomer(string id)
        {
            CustomerDto customer = logic.GetOne(id);
            CustomerView cus = new CustomerView()
            {
                CustomerID = (customer.CustomerID).ToUpper(),
                CompanyName = customer.CompanyName,
                ContactName = customer.ContactName,
                City = customer.City,
                Country = customer.Country,
                Phone = customer.Phone
            };
            return cus;
        }

        //New Customer - OK
        /*[HttpPost]
        public IHttpActionResult AddCustomer([FromBody] CustomerDto customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var customerEntity = new CustomerDto()
                    {
                        CustomerID = (customer.CustomerID).ToUpper(),
                        CompanyName = customer.CompanyName,
                        ContactName = customer.ContactName,
                        City = customer.City,
                        Country = customer.Country,
                        Phone = customer.Phone
                    };
                    logic.Add(customerEntity);
                    return Ok(customer);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }*/
        [HttpPost]
        public string AddCustomer([FromBody] CustomerDto customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var customerEntity = new CustomerDto()
                    {
                        CustomerID = (customer.CustomerID).ToUpper(),
                        CompanyName = customer.CompanyName,
                        ContactName = customer.ContactName,
                        City = customer.City,
                        Country = customer.Country,
                        Phone = customer.Phone
                    };
                    logic.Add(customerEntity);
                    return ":D";
                }
                else
                {
                    return "D: (ModelNotValid (?))";
                }
            }
            catch (Exception)
            {
                return "D: (Exception)";
            }
        }

        //Delete Customer - OK
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(string id)
        {
            try
            {
                logic.Delete(id);
                return Ok(id);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        //Modify Customer
        [HttpPut]
        public IHttpActionResult UpdateCustomer(string id)
        {
            try
            {
                CustomerDto customer = logic.GetOne(id);
                var customerEntity = new CustomerDto()
                {
                    CustomerID = (customer.CustomerID).ToUpper(),
                    CompanyName = customer.CompanyName,
                    ContactName = customer.ContactName,
                    City = customer.City,
                    Country = customer.Country,
                    Phone = customer.Phone
                };
                logic.Update(customerEntity);
                return Ok(customer);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
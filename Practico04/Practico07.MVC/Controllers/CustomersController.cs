using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using Practico04.Logic;
using Practico04.Entities.DTO;
using Practico07.MVC.Models;
using System;

namespace Practico07.MVC.Controllers
{
    public class CustomersController : Controller
    {
        CustomersLogic logic = new CustomersLogic();
        public ActionResult Index()
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

            return View(customersViews);
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(CustomerView customer)
        {
            try
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
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(string id)
        {
            logic.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(CustomerView customer)
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
            logic.Update(customerEntity);
            return RedirectToAction("Index");
        }
    }
}
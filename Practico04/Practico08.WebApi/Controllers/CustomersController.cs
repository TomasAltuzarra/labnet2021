using Practico04.Data;
using Practico04.Entities;
using Practico04.Entities.DTO;
using Practico04.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practico08.WebApi.Controllers
{
    public class CustomersController : Controller
    {
        readonly CustomersLogic logic = new CustomersLogic();

        [HttpGet]
        public IEnumerable<Customers> Get()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Customers.ToList();
            }
        }
    }
}
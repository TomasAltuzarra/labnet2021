using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practico07.MVC.Models
{
    public class CustomerView
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
    }
}
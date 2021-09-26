﻿using Practico05.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico05.Logic
{
    public class Consultas : BaseLogic
    {
        public Customers Query1(string customerId)
        {
            return context.Customers.Find(customerId);
        }
        public Customers Query1Bis()
        {
            return context.Customers.First();
        }
        public List<Products> Query2() 
        {
            return context.Products.Where(p => p.UnitsInStock == 0).ToList();
        }
        public List<Products> Query3() 
        {
            return context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3).ToList();
        }
        public void Query4() { }
        public void Query5() { }
        public void Query6() { }
        public void Query7() { }

        //Enunciados extras
        public void Query8() { }
        public void Query9() { }
        public void Query10() { }
        public void Query11() { }
        public void Query12() { }
        public void Query13() { }

    }
}

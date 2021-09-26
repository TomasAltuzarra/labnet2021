using Practico05.Entities;
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
        public Customers Query1Bis() //inciso 1 sin parametros: pasa el primer customer que encuentra
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
        public List<Customers> Query4()
        {
            //List<Customers> nombre = new List<Customers>();
            //return context.Customers.Where(c => c.Region == "WA").ToList();
            List<Customers>  clientes = (from c in context.Customers
                                        where c.Region == "WA"
                                        select c).ToList();
            return clientes;
        }
        public Products Query5() 
        {
            return context.Products.FirstOrDefault(p => p.ProductID == 789);
        }
        public List<string> Query6() 
        {
            List<string> nombre = new List<string>(); 

            var query = from c in context.Customers
                        select new { min = c.ContactName.ToLower(), mayus = c.ContactName.ToUpper() };
            foreach (var n in query)
            {
                nombre.Add(($"{n.min} - {n.mayus}"));
            }
            return nombre;
        }

        public List<string> Query6Bis(string nomb) //inciso 6 con parametros: devuelve un customer con el nombre ingresado
        {
            List<string> nombre = new List<string>();

            var query = from c in context.Customers
                        where c.ContactName == nomb
                        select new { min = c.ContactName.ToLower(), mayus = c.ContactName.ToUpper() };
            foreach (var n in query)
            {
                nombre.Add(($"{n.min} - {n.mayus}"));
            }
            return nombre;
        }
        public List<string> Query7() 
        {
            List<string> lista = new List<string>();

            var query = from c in context.Customers
                        join o in context.Orders
                        on new { c.CustomerID }
                        equals new { o.CustomerID }
                        where c.Region == "WA" && o.OrderDate > new DateTime(1997, 01, 01)
                        select new {c.ContactName, o.OrderID};
             foreach (var q in query)
             {
                 lista.Add($"{q.ContactName} - {q.OrderID}");
             }
             return lista;
        }

        public List<string> Query7Bis() //Para corroborar en UnitTesting
        {
            List<string> lista = new List<string>();

            var query = from c in context.Customers
                        join o in context.Orders
                        on new { c.CustomerID }
                        equals new { o.CustomerID }
                        where c.Region == "WA" && o.OrderDate > new DateTime(1997, 01, 01)
                        select new { c.Region, o.OrderDate };
            foreach (var q in query)
            {
                lista.Add($"{q.Region}");
            }
            return lista;
        }
    }
}

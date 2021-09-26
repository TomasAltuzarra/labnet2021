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
        
/*
5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de
producto sea igual a 789
6. Query para devolver los nombre de los Customers.Mostrarlos en Mayuscula y en
Minuscula.
7. Query para devolver Join entre Customers y Orders donde los customers sean de la
Región WA y la fecha de orden sea mayor a 1/1/1997.


Los siguientes ejercicios no son obligatorios, pero es deseable que estén resueltos:
8. Query para devolver los primeros 3 Customers de la Región WA
9. Query para devolver lista de productos ordenados por nombre
10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.
11. Query para devolver las distintas categorías asociadas a los productos
12. Query para devolver el primer elemento de una lista de productos
13. Query para devolver los customer con la cantidad de ordenes asociadas*/
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
        public List<Customers> Query4()
        {
            return context.Customers.Where(c => c.Region == "WA").ToList();
        }
        public Products Query5() 
        {
            var query5 = context.Products.FirstOrDefault(p => p.ProductID == 789);
            return query5;
        }
        public void Query6() 
        {
            
        }
        public void Query7() 
        {
            var query = from cust in context.Customers
                        join ord in context.Orders
                        on new { cust.CustomerID }
                        equals new { ord.CustomerID }
                        where cust.Region == "WA" && ord.OrderDate > new DateTime(1997, 01, 01)
                        select new { };
        }

        //Enunciados extras
        public void Query8() { }
        public void Query9() { }
        public void Query10() { }
        public void Query11() { }
        public void Query12() { }
        public void Query13() { }

    }
}

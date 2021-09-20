using Practico04.Entities;
using Practico04.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico04
{
    class Program
    {
        static void Main()
        {
            new Program().Menu();
            Console.ReadLine();
        }

        public void Menu()
        {
            Console.WriteLine("1-Customers\n2-Employees");
            int opc = int.Parse(Console.ReadLine());

            switch(opc)
            { 
                case 1: GetCustomers(); break;
                case 2: GetEmployees(); break;
                default: Console.WriteLine("xd"); break;
            }
            return;
        }

        public void GetCustomers()
        {
            CustomersLogic customersLogic = new CustomersLogic();

            foreach (Customers customer in customersLogic.GetAll())
            {
                Console.WriteLine($"{customer.ContactName} - {customer.CompanyName}");
            }
            return;
        }

        public void GetEmployees()
        {
            EmployeesLogic employeesLogic = new EmployeesLogic();

            foreach (Employees employee in employeesLogic.GetAll())
            {
                Console.WriteLine($"{employee.LastName} - {employee.Title}");
            }
            return;
        }
    }
}

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
        static void Main(string[] args)
        {

            CustomersLogic customersLogic = new CustomersLogic();

            foreach (Customers customer in customersLogic.GetAll())
            {
                Console.WriteLine($"{customer.ContactName} - {customer.CompanyName}");
            }

            Console.ReadLine();
        }

        public void Menu()
        {
            Console.WriteLine("1-Customers\n2-Employees");
            int opc = int.Parse(Console.ReadLine());

            case(opc){ 
                case 1:
                    
                    } 
        }
    }
}

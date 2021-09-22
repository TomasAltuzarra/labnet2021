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
        static void Main() =>
           new Program().Menu();

        public void Menu()
        {
            CustomersABM c = new CustomersABM();
            int opc = 0;
            bool validar = false;
            do
            {
                do
                {
                    Console.WriteLine("Bienvenido:\n");
                    Console.WriteLine("1-Opciones Clientes\n2-Opciones Empleados");
                    Console.WriteLine("(Presione 0 para salir)");
                    Console.Write("\n Ingrese una opción: ");

                    try
                    {
                        opc = int.Parse(Console.ReadLine());
                        if (opc >= 0 && opc < 3)
                        {
                            validar = true;
                        }
                        else
                        {
                            Console.WriteLine("\n               !!\nLa opcion ingresada no es valida\n(presione Enter para continuar)");
                            Console.ReadLine();
                        }

                        Console.Clear();


                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nLa opcion ingresada debe ser un número entero");
                        Console.Write("Presione Entrer para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (validar == false);


            switch(opc)
            { 
                case 1: c.SubMenuCustomers(); break;
                case 2: GetEmployees(); break;
                default: Console.WriteLine("Gracias vuelva prontos"); break;
            }

            Console.WriteLine("(presione Enter para continuar)");
            Console.ReadKey();
            Console.Clear();

            } while (opc != 0);
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

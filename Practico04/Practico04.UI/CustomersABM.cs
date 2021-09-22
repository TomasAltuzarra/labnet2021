using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico04.Logic;
using Practico04.Entities;

namespace Practico04
{
    public class CustomersABM : IABM
    {
        public void SubMenuCustomers()
        {
            int opc = 0;
            bool validar = false;

            do
            {
                do
                {
                    Console.WriteLine("Seleccione accion a realizar:\n");
                    Console.WriteLine("Clientes");
                    Console.WriteLine("1-Listado de Clientes\n2-Buscar Cliente\n3-Agregar Cliente\n4-Modificar Cliente\n5-Eliminar Cliente");
                    Console.WriteLine("0-Volver al menu pricipal");
                    Console.Write("\n Ingrese una opción: ");

                    try
                    {
                        opc = int.Parse(Console.ReadLine());
                        if (opc >= 0 && opc < 6)
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

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Listado de clientes: ");
                        GetAll();
                        break;
                    case 2:
                        Console.Write("Ingrese ID de cliente:");
                        GetOne();
                        break;
                    case 3:
                        Console.WriteLine("Nuevo cliente:");
                        New();
                        break;
                    case 4:
                        Console.WriteLine("update Customer");
                        Update();
                        break;
                    case 5:
                        Console.WriteLine("Delete Customer");
                        Delete();
                        break;
                }

                //Console.WriteLine("(presione Enter para continuar)");
                //Console.ReadKey();
                //Console.Clear();

            } while (opc != 0);

        }

        public void GetAll()
        {
            CustomersLogic customersLogic = new CustomersLogic();

            foreach (Customers customer in customersLogic.GetAll())
            {
                Console.WriteLine($"{customer.CustomerID} - {customer.ContactName} - {customer.CompanyName} - {customer.Address} ({customer.City}, {customer.Country})");
            }
            return;
        }

        public void GetOne()
        {
            CustomersLogic customersLogic = new CustomersLogic();
            Customers customer;

            string id = Console.ReadLine().ToUpper();
            customer = customersLogic.GetOne(id);

            if (customer == null)
            {
                Console.WriteLine("\nLa ID ingresada no es valida o el cliente no existe");
                Console.Write("Presione Entrer para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"ID: {customer.CustomerID}\n{customer.ContactName} - {customer.ContactTitle}");
                Console.WriteLine($"Empresa: {customer.CompanyName}");
                Console.WriteLine($"Dirección: {customer.Address} ({customer.City}, {customer.Country})");
                Console.WriteLine($"Contacto: {customer.Phone}/{customer.Fax}");
            }

            Console.ReadKey();
            Console.Clear();
            return;
        }

        public void New()
        {
            bool validar = false;
            CustomersLogic customersLogic = new CustomersLogic();
            Customers c = new Customers();

            do
            {
                try
                {
                    Console.WriteLine("A continuacion, ingrese los datos del nuevo cliente\nTenga en cuenta:\n [!] = Campo obligatorio\n (n) = Numero máximo de caracteres permitidos");
                    Console.Write("\n[!]ID (5): "); string id = Console.ReadLine().ToUpper();
                    Console.Write("[!]Compañía (40): "); string nombreCompania = Console.ReadLine();
                    Console.Write("Nombre (30): "); string nombreCliente = Console.ReadLine();
                    Console.Write("Puesto (30): "); string puestoTitulo = Console.ReadLine();
                    Console.Write("Dirección (60): "); string direccion = Console.ReadLine();
                    Console.Write("Ciudad (15): "); string ciudad = Console.ReadLine();
                    Console.Write("Región (15): "); string region = Console.ReadLine();
                    Console.Write("Código Postal (10): "); string codpost = Console.ReadLine();
                    Console.Write("País (15): "); string pais = Console.ReadLine();
                    Console.Write("Teléfono (24): "); string tel = Console.ReadLine();
                    Console.Write("Fax (24): "); string fax = Console.ReadLine();

                    c.CustomerID = id;
                    c.CompanyName = nombreCompania;
                    c.ContactName = nombreCliente;
                    c.ContactTitle = puestoTitulo;
                    c.Address = direccion;
                    c.City = ciudad;
                    c.Region = region;
                    c.PostalCode = codpost;
                    c.Country = pais;
                    c.Phone = tel;
                    c.Fax = fax;

                    customersLogic.Add(c);
                    validar = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nLos datos ingresados no son válidos, por favor, reintente nuevamente");
                    Console.WriteLine("Presione Entrer para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
            }while (validar == false);

            Console.WriteLine("Cliente registrado con éxito");
            Console.ReadKey(); Console.Clear();
            return;
        }

        public void Update()
        {

            CustomersLogic customersLogic = new CustomersLogic();
            Customers c = new Customers();

            Console.WriteLine("Ingrese ID de cliente: ");
            string id = Console.ReadLine().ToUpper();
            c = customersLogic.GetOne(id);

            if (c == null)
            {
                Console.WriteLine("\nLa ID ingresada no es valida o el cliente no existe");
                Console.Write("Presione Entrer para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                bool validar = false;
                do
                {
                Console.Clear();
                Console.WriteLine($"\nID (5): {c.CustomerID}");
                Console.WriteLine($"Compañía (40): {c.CompanyName}");
                Console.WriteLine($"Nombre (30): {c.ContactName}");
                Console.WriteLine($"Puesto (30): {c.ContactTitle}");
                Console.WriteLine($"Dirección (60): {c.Address}");
                Console.WriteLine($"Ciudad (15): {c.City}");
                Console.WriteLine($"Región (15): {c.Region}");
                Console.WriteLine($"Código Postal (10): {c.PostalCode}");
                Console.WriteLine($"País (15): {c.Country}");
                Console.WriteLine($"Teléfono (24): {c.Phone}");
                Console.WriteLine($"Fax (24): {c.Fax}");
                Console.ReadKey();
                
                    try
                    {
                        Console.WriteLine("A continuacion, ingrese los datos del nuevo cliente\nTenga en cuenta:\n (n) = Numero máximo de caracteres permitidos");
                        Console.Write("Nombre (30): "); string nombreCliente = Console.ReadLine();
                        Console.Write("Puesto (30): "); string puestoTitulo = Console.ReadLine();
                        Console.Write("Dirección (60): "); string direccion = Console.ReadLine();
                        Console.Write("Ciudad (15): "); string ciudad = Console.ReadLine();
                        Console.Write("Región (15): "); string region = Console.ReadLine();
                        Console.Write("Código Postal (10): "); string codpost = Console.ReadLine();
                        Console.Write("País (15): "); string pais = Console.ReadLine();
                        Console.Write("Teléfono (24): "); string tel = Console.ReadLine();
                        Console.Write("Fax (24): "); string fax = Console.ReadLine();

                        c.ContactName = nombreCliente;
                        c.ContactTitle = puestoTitulo;
                        c.Address = direccion;
                        c.City = ciudad;
                        c.Region = region;
                        c.PostalCode = codpost;
                        c.Country = pais;
                        c.Phone = tel;
                        c.Fax = fax;

                        customersLogic.Update(c);
                        validar = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nLos datos ingresados no son válidos, por favor, reintente nuevamente");
                        Console.WriteLine("Presione Entrer para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (validar == false);
            }
            Console.WriteLine("Datos del cliente modificados con éxito");
            Console.ReadKey(); Console.Clear();
            return;
        }

        public void Delete()
        {
            CustomersLogic customersLogic = new CustomersLogic();
            Customers c = new Customers();

            Console.WriteLine("Ingrese ID de cliente a eliminar: ");
            string id = Console.ReadLine().ToUpper();
            c = customersLogic.GetOne(id);

            if (c == null)
            {
                Console.WriteLine("\nLa ID ingresada no es valida o el cliente no existe");
                Console.Write("Presione Entrer para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Cliente: ");
                Console.WriteLine($"\nID (5): {c.CustomerID}");
                Console.WriteLine($"Compañía (40): {c.CompanyName}");
                Console.WriteLine($"Nombre (30): {c.ContactName}");
                Console.WriteLine($"Puesto (30): {c.ContactTitle}");
                Console.WriteLine($"Dirección (60): {c.Address}");
                Console.WriteLine($"Ciudad (15): {c.City}");
                Console.WriteLine($"Región (15): {c.Region}");
                Console.WriteLine($"Código Postal (10): {c.PostalCode}");
                Console.WriteLine($"País (15): {c.Country}");
                Console.WriteLine($"Teléfono (24): {c.Phone}");
                Console.WriteLine($"Fax (24): {c.Fax}");
                Console.ReadKey();
            }

            int opc = 0;
            bool validar = false;
            int sn;

            do
            {
                do
                {
                    Console.WriteLine("Opciones:");
                    Console.WriteLine("1-Buscar un nuevo Cliente\n2-Eliminar Cliente\n");
                    Console.WriteLine("0-Volver al menú");
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

                do
                {
                    Console.WriteLine("Opciones:");
                    Console.Write($"¿Esta seguro que desea eliminar la cliente {c.CustomerID}? (Y-1/N-2): ");
                    sn = int.Parse(Console.ReadLine());

                    try
                    {
                        opc = int.Parse(Console.ReadLine());
                        if (opc >= 1 && opc <=2 )
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

                    if (sn == 1)
                    {
                        customersLogic.Delete(c.CustomerID);
                        Console.WriteLine("Cliente eliminado");
                        Console.Write("Presione Entrer para continuar");
                    }
                } while (validar == false);

            } while (validar == false);
            return;
        }  

    }
}

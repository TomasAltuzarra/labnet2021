using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico01
{
    class Program
    {
        static void Main(string[] args) =>
            new Program().Menu();

        public void Menu()
        {
            int opc=0;
            bool validar = false;
            int contadorOmnibus = 0, contadorTaxis = 0;
            List<Omnibus> colectivos = new List<Omnibus> { };
            List<Taxi> taxis = new List<Taxi> { };

            Console.WriteLine("Bienvenido Usuario, a continuación, seleccione el tipo de transporte a ingresar:");

            do
            {
                do
                {
                    Console.WriteLine("\nSelección de transporte");
                    Console.WriteLine("1– Omnibus");
                    Console.WriteLine("2– Taxi");
                    Console.WriteLine("0- Continuar al listado");
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
                        Console.WriteLine("\nLa opcion ingresada debe ser un número entero\n");
                        Console.WriteLine("Presione Entrer para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (validar == false);

                switch (opc)
                {
                    case 1:
                        contadorOmnibus++;
                        colectivos.Add(new Omnibus(CargarPasajeros(), contadorOmnibus));
                        Console.WriteLine("Se cargó con éxito Omnibus N{0}\n", contadorOmnibus);
                        Console.WriteLine("\n(presione Enter para continuar)");
                        Console.ReadKey(); 
                        Console.Clear();
                        break;
                    case 2:
                        contadorTaxis++;
                        taxis.Add(new Taxi(CargarPasajeros(), contadorTaxis));
                        Console.WriteLine("Se cargó con éxito Taxi N{0}\n", contadorTaxis);
                        Console.WriteLine("\n(presione Enter para continuar)");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 0:
                        Console.WriteLine("Listado de transportes registrados en la sesion actual: \n");
                        Console.WriteLine("Omnibuses: ");
                        foreach (Omnibus cole in colectivos)
                        {
                            Console.Write("N:0{0} :", cole.id);
                            Console.WriteLine(" {0} pasajeros", cole.cantidadPasajeros);
                        }
                        Console.WriteLine("Taxis: ");
                        foreach (Taxi tacho in taxis)
                        {
                            Console.Write("N:0{0} :", tacho.id);
                            Console.WriteLine(" {0} pasajeros", tacho.cantidadPasajeros);
                        }
                        Console.WriteLine("\nGracias vuelva prontos");
                        break;
                }
            } while (opc != 0);

            Console.ReadKey();
        }

        public int CargarPasajeros()
        {
            int cantidad=0;
            do
            {
                try
                {
                    Console.WriteLine("Nuevo Vehículo\n");
                    Console.Write("Ingrese cantidad de pasajeros: ");
                    cantidad = int.Parse(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("\nLa cantidad ingresada debe ser un número entero\n");
                    Console.WriteLine("Presione Entrer para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }   

            } while (cantidad == 0);
            return cantidad;
        }
    }
}

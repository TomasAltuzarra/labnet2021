using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico02.Extensiones;

namespace Practico02
{
    class Program
    {

        static void Main(string[] args) =>
            new Program().Menu();

        public void Menu()
        {
            int opc = 0;
            bool validar = false;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese un numero entre 1 y 4 para el inciso correspondiente");
                    Console.WriteLine("(Presione 0 para salir)");
                    Console.Write("\n Ingrese una opción: ");

                    try
                    {
                        opc = int.Parse(Console.ReadLine());
                        if (opc >= 0 && opc < 4)
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
                        Inciso1();
                        break;
                    case 2:
                        Inciso2();

                        break;
                    case 3:
                        Inciso3();
                        break;
                    case 4:
                        Inciso4();
                        break;
                    case 0:
                        Console.WriteLine("\nGracias vuelva prontos");
                        break;
                }

                Console.WriteLine("\n(presione Enter para continuar)");
                Console.ReadKey();
                Console.Clear();

            } while (opc != 0);

            //Console.ReadKey();
        }

        static void Inciso1()
        {
            int div;
            float resultado = 0;
            bool operacion = true;
            Console.Write("Ingrese numero a intentar dividir por cero: ");
            div = int.Parse(Console.ReadLine());

            try
            {
                resultado = div.Dividir();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!");
                Console.WriteLine("No es posible dividir por cero!");
                operacion = false;
                Console.ReadKey();
            }

            string final = (operacion) ? "ha sido exitosa" : "no ha sido exitosa";
            Console.WriteLine($"La operacion {final}");

        }

        static void Inciso2()
        {
            int div1, div2;
            float resultado = 0;
            bool operacion = true;

            try
            {
                Console.Write("\nIngrese entero dividendo: ");
                div1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese entero divisor: ");
                div2 = int.Parse(Console.ReadLine());
                resultado = div1.Dividir(div2);
            }
            catch (DivideByZeroException)
            {
                Console.Clear();
                Console.WriteLine("\n                                             ¡Error!");
                Console.WriteLine("\n                               ¡¿Estas loco, dividir por cero?!");
                Console.WriteLine("\n     ALERTA: El Sujeto intenta romper las leyes matematicas, la matrix se encuentra en peligro");
                Console.WriteLine("         Antencion Sujeto: quedese donde esta, un agente llegara pronto a su localizacion");
                Console.WriteLine("                                       Que tenga un buen dia");
                operacion = false;
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("       ¡Error!");
                Console.WriteLine("¡Eso no es un numero!");
                operacion = false;
                Console.ReadKey();
            }

            Console.WriteLine("\n");
            string final = (operacion) ? $"ha sido exitosa (Resultado {resultado})" : "no ha sido exitosa";
            Console.WriteLine($"La operacion {final}");

        }

        static void Inciso3()
        {

        }

        static void Inciso4()
        {

        }
    }
}


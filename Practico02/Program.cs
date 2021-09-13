using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico02.Extensiones;

namespace Practico02
{
    public class Program
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
                        if (opc >= 0 && opc < 5)
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
                        Console.WriteLine("Gracias vuelva prontos");
                        break;
                }

                Console.WriteLine("(presione Enter para continuar)");
                Console.ReadKey();
                Console.Clear();

            } while (opc != 0);

        }

        public static void Inciso1()
        {
            int div;
            double resultado = 0;
            bool operacion = true;
            Console.Write("Ingrese numero a intentar dividir por cero: ");
            div = int.Parse(Console.ReadLine());

            try
            {
                resultado = div.Dividir();
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
                Console.WriteLine("No es posible dividir por cero!");
                operacion = false;
            }

            string final = (operacion) ? "ha sido exitosa" : "no ha sido exitosa";
            Console.WriteLine($"La operacion {final}");

        }

        public static void Inciso2()
        {
            int div1, div2;
            double resultado = 0;
            bool operacion = true;

            try
            {
                Console.Write("Ingrese entero dividendo: ");
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
                Console.WriteLine("\n     ALERTA: El Sujeto intenta romper las leyes matemáticas, la matrix se encuentra en peligro (no mostrar esta línea)");
                Console.WriteLine("         Antención Sujeto: quedese donde esta, un agente llegara pronto a su localización");
                Console.WriteLine("                                       Que tenga un buen día");
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

        public static void Inciso3()
        {
            Console.WriteLine("En la siguiente pantalla, se intenta asignar un valor booleano a un string,\nel mismo es un valor nulo, y es capturado como excepcion");
            Console.WriteLine("(Presione Enter para continuar)");
            Console.ReadKey();
            Console.Clear();

            Logic logica = new Logic(null);

            try
            {
                string pasar = logica.valida.Value.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Eror! La variable no es ni Verdadero ni Falso");
                Console.WriteLine(e.Message);
            }
        }

        public static void Inciso4()
        {
            Console.WriteLine("A continuación se captura muestra un mensaje de una excepción personalizada");
            Console.WriteLine("(Presione Enter para continuar)");
            Console.ReadKey();
            Console.Clear();

            try
            {
                throw new CustomException();
            }
            catch (Exception e)
            {
                Console.WriteLine("Captura2");
                Console.WriteLine(e.Message);
            }
        }
    }
}


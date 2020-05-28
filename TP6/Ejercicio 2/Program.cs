using System;
using System.Runtime.ExceptionServices;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0, a, b;
            do
            {
                Console.WriteLine("----CALCULADORA SIMPLE---");
                Console.WriteLine("1 - Suma");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - Multiplicacion");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - Salir");
                Console.WriteLine("Ingrese una opcion:");


                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Ingrese un numero:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el otro numero distinto de 0:");
                b = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {

                    //SUMA
                    case 1:
                        Console.WriteLine("El resultado de la suma es " + (a + b));
                        string respuesta1;
                        do
                        {
                            Console.WriteLine("¿Desea realizar otra operacion?[Si/No]");
                            respuesta1 = Console.ReadLine();//Lee la tecla presionada
                        } while (respuesta1.ToUpper() != "N"); //Controla el loop
                        if (respuesta1 == "N")
                        {
                            Console.Clear();
                            break;
                        }
                        else return;

                    //RESTA
                    case 2:
                        Console.WriteLine("El resultado de la resta es " + (a - b));
                        string respuesta2;
                        do
                        {
                            Console.WriteLine("¿Desea realizar otra operacion?[Si/No]");
                            respuesta2 = Console.ReadLine();//Lee la tecla presionada
                        } while (respuesta2.ToUpper() != "N"); //Controla el loop
                       
                        if (respuesta2 == "N")
                        {
                            Console.Clear();
                            break;
                        }
                        else return;

                    //MULTIPLICACION
                    case 3:
                        Console.WriteLine("El resultado de la multiplicacion es " + (a * b));
                        string respuesta3;
                        do
                        {
                            Console.WriteLine("¿Desea realizar otra operacion?[Si/No]");
                            respuesta3 = Console.ReadLine();//Lee la tecla presionada
                        } while (respuesta3.ToUpper() != "N"); //Controla el loop
                       
                        if (respuesta3 == "N")
                        {
                            Console.Clear();
                            break;
                        }
                        else return;

                    //DIVISION
                    case 4:
                        Console.WriteLine("El resultado de la division es " + (a / b));
                        string respuesta4;
                        do
                        {
                            Console.WriteLine("¿Desea realizar otra operacion?[Si/No]");
                            respuesta4 = Console.ReadLine();//Lee la tecla presionada
                        } while (respuesta4.ToUpper() != "N"); //Controla el loop

                        if (respuesta4 == "N")
                        {
                            Console.Clear();
                            break;
                        }
                        else return;

                    case 5:
                        break;
                }
            } while (opcion != 5);

        }
    }
}

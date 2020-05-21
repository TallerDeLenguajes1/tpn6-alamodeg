using System;
using System.Runtime.ExceptionServices;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion=0;
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
                

                switch (opcion)
                {
                    //SUMA
                    case 1:
                        int a, b;
                        ConsoleKey respuesta; //Crea una variable para almacenar la tecla presionada

                        Console.WriteLine("Ingrese un numero para calcular la suma:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el otro numero para calcular la suma:");
                        b = Convert.ToInt32(Console.ReadLine());
                       
                        Console.WriteLine("El resultado de la suma es " + (a+b));
                        do
                        {
                            Console.WriteLine("¿Desea realizar otra operacion?[ss/nn]");
                            Console.ReadKey();//Lee la tecla presionada
                            respuesta = Console.ReadKey().Key; // Guarda la respuesta del usuario
                            Console.WriteLine(); // Breaks the line.
                        } while (respuesta != ConsoleKey.S && respuesta != ConsoleKey.N); //Controla el loop
                        if (respuesta == ConsoleKey.S)
                        {
                            Console.Clear();
                            break;
                        }
                        else return;
                    //RESTA
                    case 2:
                        int c, d;

                        Console.WriteLine("Ingrese un numero para calcular la resta:");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el otro numero para calcular la resta:");
                        d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El resultado de la resta es " + (c - d));

                        do
                        {
                            Console.WriteLine("¿Desea realizar otra operacion?[ss/nn]");
                            Console.ReadKey();
                            respuesta = Console.ReadKey().Key;
                            Console.WriteLine();
                        } while (respuesta != ConsoleKey.S && respuesta != ConsoleKey.N);
                        if (respuesta == ConsoleKey.S)
                        {
                            Console.Clear();
                            break;
                        }
                        else return;
                    //MULTIPLICACION
                    case 3:
                        int e, f;

                        Console.WriteLine("Ingrese un numero para calcular el producto:");
                        e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el otro numero para el producto:");
                        f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El resultado del producto es " + (e * f));

                        do
                        {
                            Console.WriteLine("¿Desea realizar otra operacion?[ss/nn]");
                            Console.ReadKey();
                            respuesta = Console.ReadKey().Key; 
                            Console.WriteLine(); 
                        } while (respuesta != ConsoleKey.S && respuesta != ConsoleKey.N);
                        if (respuesta == ConsoleKey.S)
                        {
                            Console.Clear();
                            break;
                        }
                        else return;
                    //DIVISION
                    case 4:
                        int g, h;

                        Console.WriteLine("Ingrese un numero para calcular el cociente:");
                        e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el otro numero para el cociente(distinto de 0):");
                        f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El resultado del cociente es " + (e / f));

                        do
                        {
                            Console.WriteLine("¿Desea realizar otra operacion?[ss/nn]");
                            Console.ReadKey();
                            respuesta = Console.ReadKey().Key;
                            Console.WriteLine();
                        } while (respuesta != ConsoleKey.S && respuesta != ConsoleKey.N);
                        if (respuesta == ConsoleKey.S)
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

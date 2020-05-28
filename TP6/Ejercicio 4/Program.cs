using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            string cadenita = "Cadena de prueba";
            string cadenita2 = "PAN CASEROO PAN CASEROOOOOO!!!";
            Console.WriteLine("Ingrese una cadena de texto:");
            cadena = Console.ReadLine();
            Console.WriteLine("Letras cualquiera de la cadena: " + cadena[0] + cadena[3] + cadena[4]);
            Console.WriteLine("Largo de la cadena: " + cadena.Length);
            Console.WriteLine("Al unir 2 cadenas el resultado es: " + cadena + cadenita);
            Console.WriteLine("La cadena usando Substring: " + cadena.Substring(0, 3));
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("--CALCULADORA--");
            Console.WriteLine("Ingrese un numero: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: "); int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado de sumar " + a + " y " + b + " es " + (a + b));
            Console.ReadKey();
            Console.Clear();
            /*
        foreach (char c in cadena)
        {
            Console.WriteLine(c);
        }
        Console.WriteLine("Convertir " +cadenita2+" a " + cadenita2.ToLower());
        if(contain)*/

        }
    }
}

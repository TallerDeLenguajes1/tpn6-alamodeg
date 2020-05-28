using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            string cadenita = "----soy de prueba----";
            string cadenita2 = "PANCASEROO PANCASEROOOOOO!!!";

            Console.WriteLine("Ingrese una cadena de texto:");
            cadena = Console.ReadLine();
            Console.WriteLine("Letras cualquiera de la cadena: " + cadena[0] + cadena[3] + cadena[4]);
            Console.WriteLine("Largo de la cadena: " + cadena.Length);
            Console.WriteLine("Concatenacion de cadenas: " + cadena + cadenita);
            Console.WriteLine("Cadena usando Substring: " + cadena.Substring(0, 3));
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("--CALCULADORA--");
            Console.WriteLine("Ingrese un numero: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: "); int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado de sumar " + a + " y " + b + " es " + (a + b));
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Cambio de Minus a Mayus:" + cadenita2 + " a " + cadenita2.ToLower());
            Console.ReadKey();
            Console.Clear();

            string cadenita3 = "TEST+DE+LA+CADENA+QUE+SE+ROMPIO+EL+ESPACIO";
            string[] arreglo = cadenita3.Split('+');
            foreach (string c in arreglo)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("¿La variable string 'cadenita2' contiene la palabra 'CASERO'?  " + cadenita2.Contains("CASERO"));    
            if (String.Equals(cadenita,cadenita2)) Console.WriteLine("{0} y {1} son iguales");
            else Console.WriteLine($"{cadenita} y {cadenita2} son distintas");
        }
    }
}

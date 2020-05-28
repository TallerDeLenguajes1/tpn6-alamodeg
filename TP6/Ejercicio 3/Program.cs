using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            float num2 = 80.264f;
            int num3, num4;

            Console.WriteLine("Ingrese un numero");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor Absoluto: " + Math.Abs(num));
            Console.WriteLine("Cuadrado: " + Math.Pow(num, 2));
            Console.WriteLine("Cuadrado: " + Math.Sqrt(num));
            Console.WriteLine("Seno: " + Math.Sin(num));
            Console.WriteLine("Coseno: " + Math.Cos(num));
            Console.WriteLine("Parte entera de un float: " + (int)num2);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ingrese un numero"); num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero"); num4 = Convert.ToInt32(Console.ReadLine());

            if (num3 > num4) Console.WriteLine("El numero " + num3 + " es mayor que " + num4);
            else if (num3 < num4) Console.WriteLine("El numero " + num4 + " es mayor que " + num3);
            else Console.WriteLine("Los numeros " + num3 + " son iguales");
        }
    }
}

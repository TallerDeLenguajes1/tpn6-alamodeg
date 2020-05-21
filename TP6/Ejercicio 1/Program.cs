using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto;
            int reverso = 0;
            do
            {
                Console.WriteLine("Ingrese un numero POSITIVO para mostrar su reverso: ");
                num = Convert.ToInt32(Console.ReadLine());
            }while ( num <= 0);

            Console.WriteLine("El numero ingresado es " + num);
            while (num >0)
            {
                resto = num % 10;
                num = num / 10;
                reverso = (reverso + resto) * 10;
            }
            reverso = reverso / 10; //Eliminar el 0 de la operacion anterior
            Console.WriteLine("El reverso del numero es " + reverso);
        }
    }
}

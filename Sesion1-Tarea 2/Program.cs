using System;

namespace Sesion1_Tarea_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int num1 = 7;
            int num2 = 8;
            double num3 = 3.67;
            double suma;
            suma = num1 + num3;

            Console.WriteLine("La suma es: " + suma);

            string valor1 = Console.ReadLine();

            Console.WriteLine("El número introducido es el " + valor1);

            int valorint = Convert.ToInt32(valor1);

            Console.ReadKey();

        }
    }
}

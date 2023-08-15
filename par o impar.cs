using System;

namespace ParOImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificador de Número Par o Impar");
            Console.WriteLine("===============================");

            Console.Write("Ingrese un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"El número {numero} es par.");
            }
            else
            {
                Console.WriteLine($"El número {numero} es impar.");
            }
        }
    }
}
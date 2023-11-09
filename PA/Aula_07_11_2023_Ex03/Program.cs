using System;

namespace Aula_07_11_2023_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Disigite o Número Desejado: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("O número é par");
            else
                Console.WriteLine("O número é impar");
        }
    }
}

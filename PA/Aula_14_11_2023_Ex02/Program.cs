using System;

namespace Aula_14_11_2023_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFinal;

            Console.Write("Informe o Número Desejado: ");
            numeroFinal = int.Parse(Console.ReadLine());

            Console.WriteLine("Números Impares");
            Console.WriteLine("-----------------------------------------------------------------------");
            for (int i = 1; i <= numeroFinal; i++)
            {
                if (i % 2 != 0)
                    Console.Write($"{i}   ");
            }
        }
    }
}
using System;

namespace Aula_14_11_2023_Ex01
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int numero1, numero2;

        //    for (int i = 1; i <= 3; i++)
        //    {
        //        Console.WriteLine($"{i}º Conta");
        //        Console.WriteLine("--------------------------------------");

        //        Console.Write("Digite o 1º Número: ");
        //        numero1 = int.Parse(Console.ReadLine());

        //        Console.Write("Digite o 2º Número: ");
        //        numero2 = int.Parse(Console.ReadLine());

        //        Console.WriteLine($"Resultado: {numero1 - numero2}");
        //        Console.WriteLine();
        //        Console.WriteLine();
        //        Console.WriteLine();
        //    }

        //    Console.WriteLine("*** FIM ***");
        //}

        static void Main(string[] args)
        {
            int num1, num2;

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Digite o 1º Número: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o 2º Número: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Resultado: {num1 - num2}");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}

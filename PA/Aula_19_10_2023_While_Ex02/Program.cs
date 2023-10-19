using System;

namespace Aula_19_10_2023_While_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int fator;

            Console.Write("Informe o Fator: ");
            fator = int.Parse(Console.ReadLine());

            //2 x 1 = 2
            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine($"{fator} x {contador} = {fator * contador}");
                //contador = contador + 1;
                contador++;
            }
            Console.WriteLine("*** Fim da Tabuada ***");
        }
    }
}

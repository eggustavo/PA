using System;

namespace Aula_19_10_2023_While_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int fator;
            int numeroFinal;

            Console.Write("Informe o Fator: ");
            fator = int.Parse(Console.ReadLine());

            Console.Write("Informe o Nº Final: ");
            numeroFinal = int.Parse(Console.ReadLine());

            //2 x 1 = 2
            int contador = 1;
            while (contador <= numeroFinal)
            {
                Console.WriteLine($"{fator} x {contador} = {fator * contador}");
                //contador = contador + 1;
                contador++;
            }
            Console.WriteLine("*** Fim da Tabuada ***");
        }
    }
}

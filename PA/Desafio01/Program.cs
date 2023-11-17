using System;

namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 1;
            int totalIdade = 0;
            int qtdeIdadeDigitada = 0;

            while (idade != 0)
            {
                Console.Write("Informe uma Idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade == 0)
                    break;

                //totalIdade = totalIdade + idade;
                totalIdade += idade;

                //qtdeIdadeDigitada = qtdeIdadeDigitada + 1;
                qtdeIdadeDigitada++;
            }

            Console.WriteLine($"Média das Idades: {totalIdade / (qtdeIdadeDigitada)}");
        }
    }
}

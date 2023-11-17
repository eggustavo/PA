using System;

namespace Desafio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int totalIdade = 0;
            int qtdeIdadeDigitada = 0;

            do
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
            while (idade != 0);

            Console.WriteLine($"Média das Idades: {totalIdade / (qtdeIdadeDigitada)}");
        }
    }
}

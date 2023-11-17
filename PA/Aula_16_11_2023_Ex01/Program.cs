using System;

namespace Aula_16_11_2023_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int todaIdadeInformada = 0;
            int somaIdade = 0;


            for (int i = 1; i > 0; i++)
            {
                Console.Write("Digite uma idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade == 0)
                {
                    todaIdadeInformada = i - 1;
                    break;
                }

                somaIdade += idade;
            }

            Console.WriteLine($"Média das idades informada é: {somaIdade / todaIdadeInformada}");
        }
    }
}

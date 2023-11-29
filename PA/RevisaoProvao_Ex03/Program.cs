using System;

namespace RevisaoProvao_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int totalNumerosImpares = 0;
            int contador = 1;

            do
            {
                Console.Write("Digite um número inteiro: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 != 0)
                {
                    totalNumerosImpares++;
                }

                contador++;
            }
            while (contador <= 15); // ou contador < 16

            Console.WriteLine($"Total de Números Impares Informado: { totalNumerosImpares}");
        }
    }
}

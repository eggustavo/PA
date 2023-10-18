using System;

namespace Aula_17_10_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, resultado;
            string operador;
            float valor = 10;

            Console.Write("Digite um numero: ");
            num1 = float.Parse(Console.ReadLine());

            Console.Write("Digite outro numero: ");
            num2 = float.Parse(Console.ReadLine());

            Console.Write("Digite um operador que deseja para realizar a conta: ");
            operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado é: " + resultado);
                    break;
                case "-":
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado é: " + resultado);
                    break;
                case "*":
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado é: " + resultado);
                    break;
                case "/":
                    resultado = num1 / num2;
                    Console.WriteLine("O resultado é: " + resultado);
                    break;
                default:
                    Console.WriteLine("Operador Inválido");
                    break;
            }

            switch (valor)
            {
                case 10.50f:
                    Console.WriteLine("Operador Inválido");
                    break;
                case 2:
                    Console.WriteLine("Operador Inválido");
                    break;
                default:
                    Console.WriteLine("Operador Inválido");
                    break;
            }
        }
    }
}

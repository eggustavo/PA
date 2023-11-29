using System;

namespace RevisaoProvao_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string operador;

            Console.Write("Digite o 1º número inteiro: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2º número inteiro: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o Operador Matemático: ");
            operador = Console.ReadLine();

            || &&

            switch (operador)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("Operador Inválido");
                    break;
            }
        }
    }
}

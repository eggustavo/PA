using System;

namespace RevisaoProvao_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero <= 10)
            {
                //Fazer tabuada do 5
                for (int contador = 1; contador <= 10; contador++)
                {
                    Console.WriteLine($"5 x {contador} = {5 * contador}");
                }
            }
            else if (numero >= 11 && numero <= 20) //else if sem  o uso das {}
            {
                //Fazer tabuada do 8
                for (int contador = 1; contador <= 10; contador++)
                {
                    Console.WriteLine($"8 x {contador} = {8 * contador}");
                }
            }
            else
            {
                //Fazer tabuada do 7 (de trás para frente)
                for (int contador = 10; contador >= 1; contador--)
                {
                    Console.WriteLine($"7 x {contador} = {7 * contador}");
                }
            }
        }
    }    
}

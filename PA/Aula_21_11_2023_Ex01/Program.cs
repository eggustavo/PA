using System;

namespace Aula_21_11_2023_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura;
            float maiorAltura = 0, menorAltura = 0;
            int contador = 1;

            Console.WriteLine("*** Usando o While ***");
            Console.WriteLine("");
            Console.WriteLine("");

            while (contador <= 5)
            {
                Console.Write("Informe a sua Altura: ");
                altura = float.Parse(Console.ReadLine());

                if (altura >= maiorAltura)
                    maiorAltura = altura;

                if (altura <= menorAltura || menorAltura == 0)
                    menorAltura = altura;

                contador++;
            }

            Console.WriteLine($"Maior Altura: {maiorAltura}");
            Console.WriteLine($"Menor Altura: {menorAltura}");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*** Usando o For ***");
            Console.WriteLine("");
            Console.WriteLine("");

            //Usando o For
            maiorAltura = 0;
            menorAltura = 0;
            for (int cont = 1; cont <= 5; cont++)
            {
                Console.Write("Informe a sua Altura: ");
                altura = float.Parse(Console.ReadLine());

                if (altura >= maiorAltura)
                    maiorAltura = altura;

                if (altura <= menorAltura || menorAltura == 0)
                    menorAltura = altura;
            }

            Console.WriteLine($"Maior Altura: {maiorAltura}");
            Console.WriteLine($"Menor Altura: {menorAltura}");


        }
    }
}

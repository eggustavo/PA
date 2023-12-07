using System;

namespace Aula_23_11_2023_Ex01
{
    class Program
    {        
        static void Main(string[] args)
        {
            try
            {
                Votacao();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu o seguinte problema: {ex.Message}");
                Console.Write("Pressione uma tecla para continuar");
                Console.ReadLine();
                Votacao();
            }
            finally
            {
                Console.WriteLine("Sempre é executado");
            }
        }

        static void Votacao()
        {
            int voto = -1;
            int totalVotoCand01 = 0,
                totalVotoCand02 = 0,
                totalVotoCand03 = 0,
                totalVotoCand04 = 0,
                totalVotoNulos = 0,
                totalVotoBrancos = 0,
                totalVotos;

            while (voto != 0)
            {
                Console.Clear();
                Console.WriteLine("******* Opções *******");
                Console.WriteLine("----------------------");
                Console.WriteLine("1 - Candidato 01");
                Console.WriteLine("2 - Candidato 02");
                Console.WriteLine("3 - Candidato 03");
                Console.WriteLine("4 - Candidato 04");
                Console.WriteLine("5 - Nulo");
                Console.WriteLine("6 - Branco");
                Console.WriteLine("0 - Encerra");
                Console.WriteLine("----------------------");
                Console.Write("Digite a Opção Desejada: ");
                voto = int.Parse(Console.ReadLine());

                switch (voto)
                {
                    case 1:
                        totalVotoCand01 += 1;
                        break;
                    case 2:
                        totalVotoCand02 += 1;
                        break;
                    case 3:
                        totalVotoCand03 += 1;
                        break;
                    case 4:
                        totalVotoCand04 += 1;
                        break;
                    case 5:
                        totalVotoNulos += 1;
                        break;
                    case 6:
                        totalVotoBrancos += 1;
                        break;
                    default:
                        if (voto != 0)
                        {
                            Console.WriteLine("Voto não computado");
                            Console.ReadLine();
                        }
                        break;
                }
            }

            totalVotos = totalVotoCand01 + totalVotoCand02 + totalVotoCand03 + totalVotoCand04 + totalVotoNulos + totalVotoBrancos;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("****** Apuração ******");
            Console.WriteLine("----------------------");
            Console.WriteLine($"Total de Votos Candiato 01: {totalVotoCand01}");
            Console.WriteLine($"Total de Votos Candiato 02: {totalVotoCand02}");
            Console.WriteLine($"Total de Votos Candiato 03: {totalVotoCand03}");
            Console.WriteLine($"Total de Votos Candiato 04: {totalVotoCand04}");
            Console.WriteLine($"Total de Votos Nulos: {totalVotoNulos}");
            Console.WriteLine($"Total de Votos Branos: {totalVotoBrancos}");
            Console.WriteLine($"% de Nulos: {((Convert.ToDecimal(totalVotoNulos) / Convert.ToDecimal(totalVotos)) * 100):0.00}");
            Console.WriteLine($"% de Brancos: {((Convert.ToDecimal(totalVotoBrancos) / Convert.ToDecimal(totalVotos)) * 100):0.00}");

            decimal totalVotoNulosDecimal = Convert.ToDecimal(totalVotoNulos);
            decimal totalVotoBrancosDecimal = Convert.ToDecimal(totalVotoBrancos);
            decimal totalVotosDecimal = Convert.ToDecimal(totalVotos);

            decimal percVotoNulos = (totalVotoNulosDecimal / totalVotosDecimal) * 100;
            decimal percVotoBrancos = (totalVotoBrancosDecimal / totalVotosDecimal) * 100;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"% de Nulos: {percVotoNulos:0.00}");
            Console.WriteLine($"% de Brancos: {percVotoBrancos:0.00}");

        }
    }
}

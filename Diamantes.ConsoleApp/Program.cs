using System;

namespace Diamantes.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanho, espacosEmBranco ;
            Console.WriteLine("Digite um número ímpar: ");
            tamanho = Convert.ToInt32(Console.ReadLine());
            espacosEmBranco = (tamanho - 1) / 2;
            int numeroDeGiros = (tamanho - 1) / 2;
            int quantidadeDeX = 1;

            for(int i = 0; i < numeroDeGiros; i++) // Controla espaços e x
            {
                for(int j = 0; j < espacosEmBranco; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < quantidadeDeX; j++)
                {
                    Console.Write("x");
                }
                espacosEmBranco--;
                quantidadeDeX += 2;
                Console.WriteLine();
            }

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("x");
            }
            Console.WriteLine();
            espacosEmBranco++;
            quantidadeDeX -= 2;

            for (int i = 0; i < numeroDeGiros; i++) // Controla espaços e x
            {
                for (int j = 0; j < espacosEmBranco; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < quantidadeDeX; j++)
                {
                    Console.Write("x");
                }
                espacosEmBranco++;
                quantidadeDeX -= 2;
                Console.WriteLine();
            }
        }
    }
}
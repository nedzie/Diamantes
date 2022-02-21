using System;

namespace Diamantes.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanho, espacosEmBranco, numeroDeGiros, quantidadeDeX;
            RecebimentoDeInformacoes(out tamanho, out espacosEmBranco, out numeroDeGiros, out quantidadeDeX);
            ImprimeParteSuperior(ref espacosEmBranco, numeroDeGiros, ref quantidadeDeX);
            ImprimeParteInferior(tamanho, ref espacosEmBranco, numeroDeGiros, ref quantidadeDeX);
        }
        #region Métodos
        static void RecebimentoDeInformacoes(out int tamanho, out int espacosEmBranco, out int numeroDeGiros, out int quantidadeDeX)
        {
            Console.WriteLine("Digite um número ímpar: ");
            tamanho = Convert.ToInt32(Console.ReadLine());
            espacosEmBranco = (tamanho - 1) / 2;
            numeroDeGiros = (tamanho - 1) / 2;
            quantidadeDeX = 1;
        }
        private static void ImprimeParteSuperior(ref int espacosEmBranco, int numeroDeGiros, ref int quantidadeDeX)
        {
            for (int i = 0; i < numeroDeGiros; i++) // Controla espaços e x
            {
                NewMethod(espacosEmBranco);
                for (int j = 0; j < quantidadeDeX; j++)
                {
                    Console.Write("x");
                }
                espacosEmBranco--;
                quantidadeDeX += 2;
                Console.WriteLine();
            }
        }

        private static void NewMethod(int espacosEmBranco)
        {
            for (int j = 0; j < espacosEmBranco; j++)
            {
                Console.Write(" ");
            }
        }

        private static void ImprimeParteInferior(int tamanho, ref int espacosEmBranco, int numeroDeGiros, ref int quantidadeDeX)
        {
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
        #endregion
    }
}
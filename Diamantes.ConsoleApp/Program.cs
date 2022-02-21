using System;

namespace Diamantes.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanho, espacosEmBranco, numeroDeGiros, quantidadeDeX; //Variáveis
            RecebimentoDeInformacoes(out tamanho, out espacosEmBranco, out numeroDeGiros, out quantidadeDeX);
            ImprimeParteSuperior(ref espacosEmBranco, numeroDeGiros, ref quantidadeDeX);
            ImprimeParteInferior(tamanho, ref espacosEmBranco, numeroDeGiros, ref quantidadeDeX);
        }
        #region Métodos
        static void RecebimentoDeInformacoes(out int tamanho, out int espacosEmBranco, out int numeroDeGiros, out int quantidadeDeX) // O método recebe (variáveis) e processa
        {
            Console.WriteLine("Digite um número ímpar: ");
            tamanho = Convert.ToInt32(Console.ReadLine());
            espacosEmBranco = (tamanho - 1) / 2;
            numeroDeGiros = (tamanho - 1) / 2;
            quantidadeDeX = 1;
        }
        static void ImprimeParteSuperior(ref int espacosEmBranco, int numeroDeGiros, ref int quantidadeDeX)
        {
            for (int i = 0; i < numeroDeGiros; i++) // Controla espaços e x
            {
                ImprimirEspacosEmBranco(espacosEmBranco);
                for (int j = 0; j < quantidadeDeX; j++)
                {
                    Console.Write("x");
                }
                espacosEmBranco--;
                quantidadeDeX += 2;
                Console.WriteLine();
            }
        }

        static void ImprimirEspacosEmBranco(int espacosEmBranco)
        {
            for (int j = 0; j < espacosEmBranco; j++)
            {
                Console.Write(" ");
            }
        }

        static void ImprimeParteInferior(int tamanho, ref int espacosEmBranco, int numeroDeGiros, ref int quantidadeDeX)
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
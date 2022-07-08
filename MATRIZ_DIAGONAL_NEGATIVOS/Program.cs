using System;

namespace MATRIZ_DIAGONAL_NEGATIVOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] A = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }
            Console.Write("Diagonal principal: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(A[i, j] + " ");
                    }
                }
            }
            Console.Write("Números negativos: ");
            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] < 0)
                    {
                        cont++;
                        Console.Write(A[i, j] + " ");
                    }
                }
            }
            Console.WriteLine($"Quantidade de negativo = {cont}.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string name = Console.ReadLine();
            char[,] matrix = new char[sizes[0], sizes[1]];
            Queue<char> row = new Queue<char>(name);
            for (int r = 0; r < sizes[0]; r++)
            {

                if (r % 2 == 0)
                {
                    for (int c = 0; c < sizes[1]; c++)
                    {
                        matrix[r, c] = row.Peek();
                        row.Enqueue(row.Dequeue());
                    }
                }
                else
                {
                    for (int c = sizes[1] - 1; c >= 0; c--)
                    {
                        matrix[r, c] = row.Peek();
                        row.Enqueue(row.Dequeue());
                    }
                }
            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}

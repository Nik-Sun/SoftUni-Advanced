using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] row = ReadArrayFromConsole();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = row[c];
                }
            }
            int maxSum = int.MinValue;
            int indexRow = 0;
            int indexCol = 0;
            for (int r = 0; r < matrix.GetLength(0) -1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) -1; c++)
                {
                    int sum = matrix[r, c] + matrix[r + 1, c] + matrix[r, c+ 1] + matrix[r + 1, c + 1];
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        indexRow = r;
                        indexCol = c;
                    }
                }
            }
            Console.WriteLine($"{matrix[indexRow,indexCol]} {matrix[indexRow,indexCol+1]}\n{matrix[indexRow+1,indexCol]} {matrix[indexRow+1,indexCol+1]}");
            Console.WriteLine(maxSum);
        }
        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                            .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
        }
    }
}

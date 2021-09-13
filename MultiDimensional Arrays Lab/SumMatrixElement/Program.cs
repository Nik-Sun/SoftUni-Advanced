using System;
using System.Linq;

namespace SumMatrixElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();
            int[,] matrix = new int[sizes[0], sizes[1]];
            int sum = 0;

            for (int i = 0; i < sizes[0]; i++)
            {
                int[] row = ReadArrayFromConsole();
                for (int j = 0; j < sizes[1]; j++)
                {
                    matrix[i, j] = row[j];
                    sum += row[j];
                }
            }
            Console.WriteLine(string.Join("\n",sizes));
            Console.WriteLine(sum);
        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
        }
    }
}

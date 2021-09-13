using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int i = 0; i < sizes[0]; i++)
            {
                int[] row = ReadArrayFromConsole();

                for (int j = 0; j < sizes[1]; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            for (int col = 0; col < sizes[1]; col++)
            {
                int sum = 0;
                for (int row = 0; row < sizes[0]; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }


        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                            .Split(new string[] {", "," " }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
        }
    }
}

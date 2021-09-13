using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadIntArrayFromConsole();
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int r = 0; r < sizes[0]; r++)
            {
                int[] row = ReadIntArrayFromConsole();
                for (int c = 0; c < sizes[1]; c++)
                {
                    matrix[r, c] = row[c];
                }
            }
            int maxSum = int.MinValue;
            int[] coords = new int[2];
            for (int r = 0; r < sizes[0]-2; r++)
            {
                for (int c = 0; c < sizes[1]-2; c++)
                {
                    int[,] miniMatrix = new int[3, 3];
                    for (int rm = 0; rm < 3; rm++)
                    {
                        for (int cm = 0; cm < 3; cm++)
                        {
                            miniMatrix[rm,cm] = matrix[r + rm, c + cm];
                        }
                    }
                    int sum = 0;
                    foreach (int item in miniMatrix)
                    {
                        sum += item;
                    }
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        coords[0] = r;
                        coords[1] = c;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int i = coords[0]; i < coords[0]+3; i++)
            {
                for (int j = coords[1]; j < coords[1]+3; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[] ReadIntArrayFromConsole()
        {
            return Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}

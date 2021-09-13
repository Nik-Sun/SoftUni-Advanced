using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int r = 0; r < size; r++)
            {
                int[] row = ReadArrayFromConsole();
                for (int c = 0; c < size; c++)
                {
                    matrix[r, c] = row[c];
                }
            }
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine(sum);
        }
        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                            .Split(new string[] {" ",", " }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
        }

    }
}

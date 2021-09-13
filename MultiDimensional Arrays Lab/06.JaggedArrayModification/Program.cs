using System;
using System.Linq;

namespace _06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int jaggedSize = int.Parse(Console.ReadLine());
            int[][] matrix = new int[jaggedSize][];

            for (int r = 0; r < jaggedSize; r++)
            {
                matrix[r] = ReadArrayFromConsole();
            }
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] data = input.Split();
                string command = data[0];
                int row = int.Parse(data[1]);
                int col = int.Parse(data[2]);
                int value = int.Parse(data[3]);
                if (row<0||row>=jaggedSize||col<0||col>=matrix[row].Length)
                {
                    Console.WriteLine($"Invalid coordinates");
                    input = Console.ReadLine();

                    continue;
                }
                else
                {
                    switch (command)
                    {
                        case"Add":
                            matrix[row][col] += value;
                            break;
                        case "Subtract":
                            matrix[row][col] -= value;
                            break;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (int[] row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
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

using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            double[][] matrix = new double[size][];

            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }

            for (int i = 0; i < size - 1; i++)
            {

                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    matrix[i] = matrix[i].Select(x => x *= 2).ToArray();
                    matrix[i + 1] = matrix[i + 1].Select(x => x *= 2).ToArray();
                }
                else
                {
                    matrix[i] = matrix[i].Select(x => x /= 2).ToArray();
                    matrix[i + 1] = matrix[i + 1].Select(x => x /= 2).ToArray();
                }

            }
            string input = Console.ReadLine().ToUpper();

            while (input != "END")
            {
                string[] commandData = input.Split();
                string command = commandData[0];
                int row = int.Parse(commandData[1]);
                int col = int.Parse(commandData[2]);
                int value = int.Parse(commandData[3]);
                if (row >= 0 && row < size && col >= 0 && col < matrix[row].Length)
                {
                    if (command=="ADD")
                    {
                        matrix[row][col] += value;
                    }
                    else if (command =="SUBTRACT")
                    {
                        matrix[row][col] -= value;
                    }
                }
                input = Console.ReadLine().ToUpper();
            }
            foreach (double[] item in matrix)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}

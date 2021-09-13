using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int triangleSize = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[triangleSize][];
            pascalTriangle[0] = new long[1];
            pascalTriangle[0][0] = 1;
            for (int i = 1; i < triangleSize; i++)
            {
                pascalTriangle[i] = new long[i + 1];
                for (int c = 0; c < pascalTriangle[i].Length; c++)
                {
                    if (pascalTriangle[i].Length==2)
                    {
                        pascalTriangle[i][c] = 1;
                    }
                    else if(c==0)
                    {
                        pascalTriangle[i][c] = 1;
                    }
                    else if (c==pascalTriangle[i].Length-1)
                    {
                        pascalTriangle[i][c] = 1;
                    }
                    else
                    {
                        pascalTriangle[i][c] = pascalTriangle[i - 1][c-1] + pascalTriangle[i-1][c];
                    }
                }
            }
            foreach (long[] item in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ",item));
            }
        }
    }
}

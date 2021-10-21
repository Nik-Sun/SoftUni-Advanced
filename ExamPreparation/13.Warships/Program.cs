using System;
using System.Linq;

namespace _13.Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] battlefield = new string[size, size];
            string[] playersCommands = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
            int playerOneShips = 0;
            int playerTwoShips = 0;
            int destrtoyedShips = 0;
            bool haveWinner = false;

            FillMatrix(size, battlefield);

            for (int i = 0; i < playersCommands.Length; i++)
            {
                int[] coords = playersCommands[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (ValidateCoords(coords, battlefield) == false)
                {
                    continue;
                }


                if (battlefield[coords[0], coords[1]] == "#")
                {
                    Detonate(battlefield, coords);
                }
                else if (battlefield[coords[0], coords[1]] == ">")
                {
                    battlefield[coords[0], coords[1]] = "X";
                }
                else if (battlefield[coords[0], coords[1]] == "<")
                {
                    battlefield[coords[0], coords[1]] = "X";
                }



            }

            for (int k = 0; k < size; k++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (battlefield[k, j] == "<")
                    {
                        playerOneShips++;
                    }
                    else if (battlefield[k, j] == ">")
                    {
                        playerTwoShips++;
                    }
                    else if (battlefield[k, j] == "X")
                    {
                        destrtoyedShips++;
                    }
                }

            }
            haveWinner = playerOneShips == 0 || playerTwoShips == 0;
            if (haveWinner)
            {
                if (playerOneShips > 0)
                {
                    Console.WriteLine($"Player One has won the game! {destrtoyedShips} ships have been sunk in the battle.");
                }
                else
                {
                    Console.WriteLine($"Player Two has won the game! {destrtoyedShips} ships have been sunk in the battle.");
                }
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {playerOneShips} ships left. Player Two has {playerTwoShips} ships left.");
            }



        }

        private static void FillMatrix(int size, string[,] battlefield)
        {
            for (int row = 0; row < size; row++)
            {
                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < size; col++)
                {
                    battlefield[row, col] = line[col];
                }
            }
        }

        private static void Detonate(string[,] battlefield, int[] coords)
        {
            battlefield[coords[0], coords[1]] = "@";
            (int row, int col)[] blast = new (int, int)[] {(coords[0]+1,coords[1]), (coords[0] -1, coords[1]), (coords[0], coords[1]+1), (coords[0] , coords[1]-1),
            (coords[0]+1,coords[1]+1),(coords[0]-1,coords[1]-1),(coords[0]+1,coords[1]-1),(coords[0]-1,coords[1]+1)};
            foreach (var (row, col) in blast)
            {
                if (ValidateCoords(new int[] { row, col }, battlefield) == false)
                {
                    continue;
                }
                if (battlefield[row, col] == "<")
                {
                    battlefield[row, col] = "X";
                }
                else if (battlefield[row, col] == ">")
                {
                    battlefield[row, col] = "X";
                }
            }
        }

        private static bool ValidateCoords(int[] coords, string[,] battlefield)
        {
            int row = coords[0];
            int col = coords[1];
            if (row >= 0 && row < battlefield.GetLength(0) && col >= 0 && col < battlefield.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}

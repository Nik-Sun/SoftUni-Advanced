using System;

namespace _02.Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int beachRows = int.Parse(Console.ReadLine());
            string[][] beach = new string[beachRows][];

            int myTokens = 0;
            int opponentTokens = 0;
            for (int i = 0; i < beachRows; i++)
            {
                string[] beachLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                beach[i] = beachLine;
            }

            string input = Console.ReadLine();
            while (input != "Gong")
            {
                string[] commandData = input.Split();
                string command = commandData[0];
                int row = int.Parse(commandData[1]);
                int col = int.Parse(commandData[2]);
                bool isValidCoords = row >= 0 && row < beachRows && col >= 0 && col < beach[row].Length;
                if (isValidCoords)
                {
                    switch (command)
                    {
                        case "Find":

                            if (beach[row][col] == "T")
                            {
                                beach[row][col] = "-";
                                myTokens++;
                            }
                            break;
                        case "Opponent":

                            string direction = commandData[3];
                            int counter = 0;
                            while (counter <= 3)
                            {
                                isValidCoords = row >= 0 && row < beachRows && col >= 0 && col < beach[row].Length;
                                if (isValidCoords)
                                {
                                    if (beach[row][col] == "T")
                                    {
                                        beach[row][col] = "-";
                                        opponentTokens++;
                                    }
                                }
                                if (direction == "up") { row--; }
                                if (direction == "down") { row++; }
                                if (direction == "left") { col--; }
                                if (direction == "right") { col++; }
                                counter++;
                            }
                            break;
                    }
                }


                input = Console.ReadLine();
            }

            foreach (var row in beach)
            {
                Console.WriteLine(string.Join(" ", row));
            }
            Console.WriteLine($"Collected tokens: {myTokens}\nOpponent's tokens: {opponentTokens}");
        }
    }
}

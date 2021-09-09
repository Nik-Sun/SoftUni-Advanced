using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            List<string> command = new List<string>();
            while (true)
            {
                command = Console.ReadLine().Split().ToList();

                if (command[0] == "Play")
                {
                    songs.Dequeue();
                    if (songs.Count==0)
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }
                }
                else if (command[0] == "Add")
                {
                    command.Remove("Add");
                    string currentSong = string.Join(" ", command);
                    if (songs.Contains(currentSong))
                    {
                        Console.WriteLine($"{currentSong} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(currentSong);
                    }

                }
                else if (command[0] == "Show" && songs.Count > 0)
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

            }

        }
    }
}

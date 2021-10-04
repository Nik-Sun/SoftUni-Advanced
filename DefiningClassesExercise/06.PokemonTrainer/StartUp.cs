using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isTournamentStarted = false;
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            while (input != "End")
            {
                if (input == "Tournament")
                {
                    isTournamentStarted = true;
                    input = Console.ReadLine();
                    continue;
                }
                if (isTournamentStarted == false)
                {
                    string[] trainerData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string trainerName = trainerData[0];
                    if (trainers.ContainsKey(trainerName) == false)
                    {
                        trainers.Add(trainerName, new Trainer(trainerName));
                    }

                    trainers[trainerName].Collection.Add(new Pokemon(trainerData[1], trainerData[2], int.Parse(trainerData[3])));

                }
                else
                {
                    foreach (var trainer in trainers)
                    {
                        int index = trainer.Value.Collection.FindIndex(p => p.Element == input);
                        if (index != -1)
                        {
                            trainer.Value.BadgesCount++;
                        }
                        else
                        {
                            foreach (Pokemon pokemon in trainer.Value.Collection)
                            {
                                pokemon.Health -= 10;
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var trainer in trainers)
            {
                trainer.Value.Collection.RemoveAll(p => p.Health<=0);
            }
            foreach (var trainer in trainers.OrderByDescending(x => x.Value.BadgesCount))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.BadgesCount} {trainer.Value.Collection.Count}");
            }
        }
    }
}

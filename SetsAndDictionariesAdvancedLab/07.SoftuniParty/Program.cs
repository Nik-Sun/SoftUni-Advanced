using System;
using System.Collections.Generic;

namespace _07.SoftuniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> VIPGuests = new HashSet<string>();
            bool isPartyStarted = false;

            while (input != "END")
            {
                if (input == "PARTY")
                {
                    isPartyStarted = true;
                }
                if (isPartyStarted)
                {
                    if (char.IsDigit(input[0]))
                    {
                        VIPGuests.Remove(input);
                    }
                    else
                    {
                        regularGuests.Remove(input);
                    }
                }
                else
                {
                    if (char.IsDigit(input[0]))
                    {
                        VIPGuests.Add(input);
                    }
                    else
                    {
                        regularGuests.Add(input);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(regularGuests.Count+VIPGuests.Count);
            foreach (var person in VIPGuests)
            {
                Console.WriteLine(person);
            }
            foreach (var person in regularGuests)
            {
                Console.WriteLine(person);
            }
        }
    }
}

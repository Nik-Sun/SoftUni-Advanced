using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Dictionary<string, Vlogger> vlog = new Dictionary<string, Vlogger>();

            while (line != "Statistics")
            {
                string[] lineInfo = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (lineInfo.Contains("joined"))
                {
                    string name = lineInfo[0];
                    Vlogger current = new Vlogger(name);
                    if (vlog.ContainsKey(name) == false)
                    {
                        vlog.Add(name, current);
                    }
                }
                else if (lineInfo.Contains("followed"))
                {
                    string follower = lineInfo[0];
                    string following = lineInfo[2];
                    if (follower != following && vlog.ContainsKey(following)&&vlog.ContainsKey(follower))
                    {
                        vlog[follower].Following.Add(following);
                        vlog[following].Followers.Add(follower);
                    }
                }

                line = Console.ReadLine();
            }
            vlog = vlog.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.Following.Count).ToDictionary(x => x.Key, x => x.Value);
            int numerator = 1;
            Console.WriteLine($"The V-Logger has a total of {vlog.Count} vloggers in its logs.");
            foreach (var vlogger in vlog)
            {
                Console.WriteLine($"{numerator}. {vlogger.Key} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Following.Count} following");
                if (numerator==1)
                {
                    foreach (var item in vlogger.Value.Followers)
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }
                numerator++;
            }
        }
    }
    class Vlogger
    {
        public Vlogger(string name)
        {
            Name = name;
            Followers = new SortedSet<string>();
            Following = new SortedSet<string>();
        }
        public string Name { get; set; }
        public SortedSet<string> Followers { get; set; }
        public SortedSet<string> Following { get; set; }
    }
}

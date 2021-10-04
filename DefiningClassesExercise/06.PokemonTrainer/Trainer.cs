using System;
using System.Collections.Generic;
using System.Text;

namespace _06.PokemonTrainer
{
    public class Trainer
    {
        public string Name { get; set; }
        public int BadgesCount { get; set; }
        public List<Pokemon> Collection { get; set; }
        public Trainer(string name)
        {
            Name = name;
            BadgesCount = 0;
            Collection = new List<Pokemon>();
        }
    }
}

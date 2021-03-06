using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        private string name;
        private string @class;
        private string rank = "Trial";
        private string description = "n/a";

        public string Name { get => name; set => name = value; }
        public string Class { get => @class; set => @class = value; }
        public string Rank { get => rank; set => rank = value; }
        public string Description { get => description; set => description = value; }
        public Player(string playerName, string playerClass)
        {
            Name = playerName;
            Class = playerClass;
        }

        public override string ToString()
        {
            return $"Player {Name}: {Class}\r\nRank: {Rank}\r\nDescription: {Description}";

        }
    }
}

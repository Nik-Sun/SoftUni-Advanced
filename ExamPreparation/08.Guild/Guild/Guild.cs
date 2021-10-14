using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private readonly List<Player> roster;
        private string name;
        private int capacity;

        public string Name { get => name; set => name = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int Count { get => roster.Count; }

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            int index = roster.FindIndex(p => p.Name == name);
            if (index == -1)
            {
                return false;
            }
            roster.RemoveAt(index);
            return true;
        }
        public void PromotePlayer(string name)
        {
            Player player = roster.Find(p => p.Name == name);
            if (player != null && player.Rank == "Trial")
            {
                player.Rank = "Member";
            }
        }
        public void DemotePlayer(string name)
        {
            Player player = roster.Find(p => p.Name == name);
            if (player != null && player.Rank == "Member")
            {
                player.Rank = "Trial";
            }
        }
        public Player[] KickPlayersByClass(string playerClass)
        {
            Player[] kickedPlayers = roster.FindAll(p => p.Class == playerClass).ToArray();
            roster.RemoveAll(p => p.Class == playerClass);
            return kickedPlayers;
        }
        public string Report()
        {
          return($"Players in the guild: {Name}\r\n{string.Join("\r\n",roster)}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TheRace
{
    class Race
    {
        private List<Racer> roster;
        public string  Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get => roster.Count; }
        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Racer>();
        }

        public void Add(Racer racer)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(racer);
            }
        }
        public bool Remove(string name)
        {
            int index = roster.FindIndex(r => r.Name == name);
            if (index == -1)
            {
                return false;
            }
            roster.RemoveAt(index);
            return true;
        }
        public Racer GetOldestRacer()
        {
            int maxAge = int.MinValue;
            Racer oldestRacer = null;
            foreach (Racer racer in roster)
            {
                if (racer.Age>maxAge)
                {
                    maxAge = racer.Age;
                    oldestRacer = racer;
                }
            }
            return oldestRacer;
        }
        public Racer GetRacer(string name)
        {
            return roster.Find(r => r.Name == name);
        }
        public Racer GetFastestRacer()
        {
            int topSpeed = int.MinValue;
            Racer fastestRacer = null;
            foreach (Racer racer in roster)
            {
                if (racer.Car.Speed >topSpeed )
                {
                    topSpeed = racer.Car.Speed;
                    fastestRacer = racer;
                }
            }
            return fastestRacer;
        }
        public string Report()
        {
            return $"Racers participating at {Name}:\r\n{string.Join("\r\n", roster)}";
        }
    }
}

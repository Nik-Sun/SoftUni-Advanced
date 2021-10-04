using System;
using System.Collections.Generic;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> data;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }

        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Ski>();
        }
        public void Add(Ski ski)
        {
            if (data.Count < Capacity)
            {
                data.Add(ski);
            }
        }
        public bool Remove(string manifacturer, string model)
        {
            int manifacturerIndex = data.FindIndex(s => s.Manifacturer == manifacturer);
            int modelIndex = data.FindIndex(s => s.Model == model);
            if (manifacturerIndex == modelIndex && modelIndex != -1)
            {
                data.RemoveAt(modelIndex);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Ski GetNewestSki()
        {
            if (data.Count==0)
            {
                return null;
            }
            int maxYear = int.MinValue;
            foreach (Ski ski in data)
            {
                if (ski.Year>maxYear)
                {
                    maxYear = ski.Year;
                }
            }
            return data[data.FindIndex(s => s.Year == maxYear)];
        }
        public Ski GetSki(string manifacturer,string model)
        {
            int manifacturerIndex = data.FindIndex(s => s.Manifacturer == manifacturer);
            int modelIndex = data.FindIndex(s => s.Model == model);
            if (manifacturerIndex == modelIndex && modelIndex != -1)
            {
                return data[modelIndex];
            }
            return null;
        }
        public string GetStatistics()
        {
            StringBuilder text = new StringBuilder($"The skis stored in {Name}:\n");
            foreach (Ski item in data)
            {
                text.AppendLine(item.ToString());
            }
            return text.ToString();
        }
    }
}

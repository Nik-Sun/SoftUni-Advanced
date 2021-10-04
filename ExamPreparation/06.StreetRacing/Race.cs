using System;
using System.Collections.Generic;
using System.Text;

namespace StreetRacing
{
    class Race
    {
         private List<Car> Participants;
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }
        public int Count { get { return Participants.Count; } }
        

        public Race(string name,string type,int laps,int capacity,int maxHorsePower)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
            Participants = new List<Car>();
        }
        public void Add(Car car)
        {
            if (Participants.FindIndex(c => c.LicensePlate == car.LicensePlate) == -1 && car.HorsePower <= MaxHorsePower && Participants.Count < Capacity)
            {
                Participants.Add(car);
            }
        }
        public bool Remove(string licensePlate)
        {
            int index = Participants.FindIndex(c => c.LicensePlate == licensePlate);
            if (index != -1)
            {
                return Participants.Remove(Participants[index]);
            }
            return false;
        }
        public Car FindParticipant(string licensePlate)
        {
            int index = Participants.FindIndex(c => c.LicensePlate == licensePlate);
            if (index != -1)
            {
                return Participants[index];
            }
            return null;
        }
        public Car GetMostPowerfulCar()
        {
            if (Participants.Count==0)
            {
                return null;
            }
            int mostPowerfulEngine = int.MinValue;
            foreach (Car car in Participants)
            {
                if (car.HorsePower > mostPowerfulEngine)
                {
                    mostPowerfulEngine = car.HorsePower;
                }
            }
            return Participants[Participants.FindIndex(c => c.HorsePower == mostPowerfulEngine)];
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            foreach (Car car in Participants)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString();
        }
    }
}

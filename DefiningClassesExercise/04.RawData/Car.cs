using System;
using System.Collections.Generic;
using System.Text;

namespace _04.RawData
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }

        public Car(string model,int engineSpeed,int enginePower,int cargoWeight,string cargoType,(double pressure,int age)[] tires)
        {
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo(cargoWeight,cargoType);
            Tires = new Tire[4];
            List<Tire> listOfTires = new List<Tire>();
            for (int i = 0; i < tires.Length; i++)
            {
                listOfTires.Add(new Tire(tires[i].pressure, tires[i].age));
            }
            Tires = listOfTires.ToArray();
        }
    }
}

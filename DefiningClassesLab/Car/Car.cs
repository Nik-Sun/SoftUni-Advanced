﻿
namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public Car()
        {
            make = "VW";
            model = "Golf";
            year = 2025;
            fuelQuantity = 200;
            fuelConsumption = 10;
        }
        public Car(string make, string model, int year)
            : this()
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,Engine engine,Tire[] tires)
            :this(make,model,year,fuelQuantity,fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }

        public string Make { get { return make; } set { make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Year { get { return year; } set { year = value; } }
        public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }
        public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public Tire[] Tires { get { return tires; } set { tires = value; } }


        public void Drive(double distnce)
        {
            if (distnce * (fuelConsumption / 100) <= fuelQuantity)
            {
                fuelQuantity -= distnce * (fuelConsumption / 100);
            }
            else
            {
                System.Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nHorsePowers: {this.Engine.HorsePower}\nFuelQuantity: {this.FuelQuantity}";
        }
    }
}

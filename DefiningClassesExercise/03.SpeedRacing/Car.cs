using System;
using System.Collections.Generic;
using System.Text;

 namespace _03.SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKM;
        private double mileage;
        public Car(string model,double fuelAmount,double fuelConsumptionPerKM)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKM = fuelConsumptionPerKM;
            mileage = 0;
        }
        public void Drive(double kilometers)
        {
            if (fuelConsumptionPerKM * kilometers <= fuelAmount)
            {
                fuelAmount -= fuelConsumptionPerKM * kilometers;
                mileage += kilometers;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public void Print()
        {
            Console.WriteLine($"{model} {fuelAmount :f2} {mileage}");
        }
    }
}

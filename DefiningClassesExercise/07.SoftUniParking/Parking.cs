using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> Cars;
        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            Cars = new List<Car>();
        }
        public int Count { get { return Cars.Count; } }

        public string AddCar(Car car)
        {
            if (Cars.FindIndex(c => c.RegistrationNumber == car.RegistrationNumber) != -1)
            {
                return "Car with that registration number, already exists!";
            }
            else if (Cars.Count == capacity)
            {
                return "Parking is full!";
            }
            else
            {
                Cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }
        public string RemoveCar(string registrationNumber)
        {
            int index = Cars.FindIndex( c => c.RegistrationNumber == registrationNumber);
            if (index == -1)
            {
               return "Car with that registration number, doesn't exist!";
            }
            else
            {
                Cars.RemoveAt(index);
                return $"Successfully removed {registrationNumber}";
            }
        }
        public Car GetCar(string registrationNumber)
        {
             return Cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string regNum in registrationNumbers)
            {
                int index = Cars.FindIndex(c => c.RegistrationNumber == regNum);
                if (index != -1)
                {
                    Cars.RemoveAt(index);
                }
            }
        }
    }
}

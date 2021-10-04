using System;
using System.Collections.Generic;
using System.Text;

namespace _05.CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string  Color { get; set; }

        public Car(string[] carData,Engine engine)
        {
            if (carData.Length == 2)
            {
                Model = carData[0];
                Engine = engine;
                Weight = "n/a";
                Color = "n/a";                
            }
            else if (carData.Length ==  3)
            {
                Model = carData[0];
                Engine = engine;
                int outInt = 0;
                if (int.TryParse(carData[2],out outInt)==false)
                {
                    Weight = "n/a";
                    Color = carData[2];
                }
                else
                {
                    Weight = outInt.ToString();
                    Color = "n/a";
                }
              
            }
            else if (carData.Length == 4)
            {
                Model = carData[0];
                Engine = engine;
                Weight = carData[2];
                Color = carData[3];
            }
        }

        public override string ToString()
        {
            return $"{Model}:\n  {Engine.Model}:\n    Power: {Engine.Power}\n    Displacement: {Engine.Displacement}\n    Efficiency: {Engine.Efficiency}\n  Weight: {Weight}\n  Color: {Color}";
        }
                                                      

    }
}

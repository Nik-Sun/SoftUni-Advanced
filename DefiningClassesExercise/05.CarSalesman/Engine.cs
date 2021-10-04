using System;
using System.Collections.Generic;
using System.Text;

namespace _05.CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string[] engineData)
        {
            if (engineData.Length == 2)
            {
                Model = engineData[0];
                Power = int.Parse(engineData[1]);
                Displacement = "n/a";
                Efficiency = "n/a";
            }
            else if (engineData.Length == 3)
            {
                Model = engineData[0];
                Power = int.Parse(engineData[1]);
                int outInt = 0;
                if (int.TryParse(engineData[2],out outInt) == false)
                {
                    Efficiency = engineData[2];
                    Displacement = "n/a";
                }
                else
                {
                    Displacement = outInt.ToString();
                    Efficiency = "n/a";
                }
            }
            else if (engineData.Length == 4)
            {
                Model = engineData[0];
                Power = int.Parse(engineData[1]);
                Displacement = engineData[2];
                Efficiency = engineData[3];
            }
        }

    }
}

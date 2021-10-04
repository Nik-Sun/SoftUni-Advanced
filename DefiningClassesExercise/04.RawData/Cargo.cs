using System;
using System.Collections.Generic;
using System.Text;

namespace _04.RawData
{
    public class Cargo
    {
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
        public Cargo(int weight,string type)
        {
            CargoWeight = weight;
            CargoType = type;
        }
    }
}

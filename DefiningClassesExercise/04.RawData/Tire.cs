﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04.RawData
{
    public class Tire
    {
        public double Pressure { get; set; }
        public int Age { get; set; }

        public Tire(double pressure,int age)
        {
            Pressure = pressure;
            Age = age;
        }
    }
}

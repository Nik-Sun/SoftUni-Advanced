using System;
namespace StreetRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Sample Code Usage:

            //Initialize Race
            Race race = new Race("RockPort Race", "Sprint", 1, 4, 150);

            //Initialize Car
            Car car = new Car("BMW", "320ci", "NFS2005", 150, 1450);

            
            race.Add(car);
            Console.WriteLine(race.GetMostPowerfulCar()); 


        }
    }
}

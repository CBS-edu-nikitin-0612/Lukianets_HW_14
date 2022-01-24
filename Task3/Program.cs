using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audiq8Car = new Car("50° 44' N", "30° 52' W", 50, 95100, 2021);
            Plane cessna172Plane = new Plane("70° 21' S", "40° 43' W", 225, 369000, 2018, 700, 4);
            Ship stellarShip = new Ship("36° 48' N", "34° 39' E", 15, 450000, 2007, 25, "Odessa");

            List<Vehicle> vehicleList = new List<Vehicle>();
            vehicleList.Add(audiq8Car);
            vehicleList.Add(cessna172Plane);
            vehicleList.Add(stellarShip);

            foreach (Vehicle vehicle in vehicleList)
                vehicle.Show();
        }
    }
}

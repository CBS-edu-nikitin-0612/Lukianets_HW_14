using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Car : Vehicle
    {
        public Car(string latitude, string longitude, double speed, double price, int releaseYear) 
            : base(latitude, longitude, speed, price, releaseYear)
        {
        }
    }
}

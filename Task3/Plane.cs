using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Plane : Vehicle
    {
        private int _heightMeters, _passengerNumber;

        public int HeightMeters
        {
            get => _heightMeters;
            set
            {
                if (value >= 0)
                    _heightMeters = value;
                else
                    Console.WriteLine("Wrong height value");
            }
        }
        public int PassengerNumber
        {
            get => _passengerNumber;
            set
            {
                if (value >= 0 && value < 1500) 
                    _passengerNumber = value;
                else
                    Console.WriteLine("Wrong passanger number");
            }
        }

        public Plane(string latitude, string longitude, double speed, double price, int releaseYear, int heightMeters, int passengerNumber) 
            : base(latitude, longitude, speed, price, releaseYear)
        {
            HeightMeters = heightMeters;
            PassengerNumber = passengerNumber;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Height: {HeightMeters}\n" +
                $"Number of passengers: {PassengerNumber}");
        }
    }
}

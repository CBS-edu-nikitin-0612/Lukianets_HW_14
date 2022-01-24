using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Vehicle
    {
        // default values
        protected string Latitude { get; set; } 
        protected string Longitude { get; set; } 

        protected double _speed, _price;
        protected int _releaseYear;

        public double Speed
        {
            get => _speed;
            set
            {
                if (value > 0)
                    _speed = value;
                else
                    Console.WriteLine("Wrong speed value");
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value > 0)
                    _price = value;
                else
                    Console.WriteLine("Wrong price value");
            }
        }

        public int ReleaseYear
        {
            get => _releaseYear;
            set
            {
                if (value > 1700)
                    _releaseYear = value;
                else
                    Console.WriteLine("Wrong release date value");
            }

        }
        public Vehicle(string latitude, string longitude, double speed, double price, int releaseYear)
        {
            Latitude = latitude;
            Longitude = longitude;
            Speed = speed;
            Price = price;
            ReleaseYear = releaseYear;
        }

        public virtual void Show()
        {
            Console.WriteLine($"\n_____Vehicle info_____\n" +
                $"{this.GetType().Name}\n" +
                $"Locatoin: ({Latitude}, {Longitude})\n" +
                $"Speed: {Speed}\n" +
                $"Price: {Price}\n" +
                $"Release year: {ReleaseYear}");
        }
    }
}

using System;

namespace Task3
{
    internal class Ship : Vehicle
    {
        private int _passengerNumber;
        private string _portName;

        public int PassengerNumber
        {
            get => _passengerNumber;
            set
            {
                if (value >= 0 && value < 10000)
                    _passengerNumber = value;
                else
                    Console.WriteLine("Wrong passanger number");
            }
        }

        public string PortName
        {
            get => _portName;
            set
            {
                if (value != null)
                    _portName = value;
                else
                    Console.WriteLine("Wrong port's name");
            }

        }

        public Ship(string latitude, string longitude, double speed, double price, int releaseYear, int passengerNumber, string portName) 
            : base(latitude, longitude, speed, price, releaseYear)
        {
            PassengerNumber = passengerNumber;
            PortName = portName;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Port name: {PortName}\n" +
                $"Number of passengers: {PassengerNumber}");
        }
    }
}

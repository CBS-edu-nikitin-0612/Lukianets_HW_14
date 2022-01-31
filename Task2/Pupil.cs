using System;

namespace Task2
{
    internal class Pupil
    {
        protected string _firstName, _lastName;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (value != null)
                    _firstName = value;
                else
                    Console.WriteLine("Wrong First Name");
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (value != null)
                    _lastName = value;
                else
                    Console.WriteLine("Wrong Last Name");
            }
        }

        public Pupil(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual void Study() => Console.WriteLine("I can study");

        public virtual void Read() => Console.WriteLine("I can read");

        public virtual void Write() => Console.WriteLine("I can write");

        public virtual void Relax() => Console.WriteLine("I can relax");

    }
}

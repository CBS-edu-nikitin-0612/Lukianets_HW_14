using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class BadPupil : Pupil
    {
        public BadPupil(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Study() => Console.WriteLine("Rarely study");

        public override void Read() => Console.WriteLine("No reading");

        public override void Write() => Console.WriteLine("Write with errors");

        public override void Relax() => Console.WriteLine("Relax, take it easy");
    }
}

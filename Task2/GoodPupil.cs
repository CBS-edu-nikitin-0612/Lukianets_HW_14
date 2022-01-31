using System;

namespace Task2
{
    internal class GoodPupil : Pupil
    {
        public GoodPupil(string firstName, string lastName) : base(firstName, lastName)
        { }

        public override void Study() => Console.WriteLine("Study good");

        public override void Read() => Console.WriteLine("Often reading");

        public override void Write() => Console.WriteLine("Good writing");

        public override void Relax() => Console.WriteLine("Good relax");
    }
}

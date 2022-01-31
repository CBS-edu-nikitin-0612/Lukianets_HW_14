using System;

namespace Task2
{
    internal class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Study() => Console.WriteLine("Excelent study");

        public override void Read() => Console.WriteLine("Reading every day");

        public override void Write() => Console.WriteLine("Excelent writing");

        public override void Relax() => Console.WriteLine("No time to relax");
    }
}

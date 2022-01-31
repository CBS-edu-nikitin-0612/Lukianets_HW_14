using System;

namespace AdditionalTask
{
    internal class IndigoMood : Printer
    {
        //public IndigoMood(string text) : base(text) { }
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            base.Print();
        }

        public override void PrintText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            base.PrintText(text);
        }
    }
}

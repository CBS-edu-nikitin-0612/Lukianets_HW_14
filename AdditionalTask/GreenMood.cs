using System;

namespace AdditionalTask
{
    internal class GreenMood : Printer
    {
        //public GreenMood(string text) : base(text) { }
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Print();
        }
        public override void PrintText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.PrintText(text);
        }
    }
}

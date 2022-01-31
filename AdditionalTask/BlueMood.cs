using System;

namespace AdditionalTask
{
    internal class BlueMood : Printer
    {
        //public BlueMood(string text) : base(text) { }

        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            base.Print();
        }
        public override void PrintText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            base.PrintText(text);
        }
    }
}

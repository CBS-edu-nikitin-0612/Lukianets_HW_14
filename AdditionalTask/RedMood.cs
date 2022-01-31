using System;

namespace AdditionalTask
{
    internal class RedMood : Printer
    {
        //public RedMood(string text) : base(text) { }
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            base.Print();
        }

        public override void PrintText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            base.PrintText(text);
        }
    }
}

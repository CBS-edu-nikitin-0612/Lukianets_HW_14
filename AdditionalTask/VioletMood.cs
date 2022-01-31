using System;

namespace AdditionalTask
{
    internal class VioletMood : Printer
    {
        //public VioletMood(string text) : base(text) { }
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            base.Print();
        }

        public override void PrintText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            base.PrintText(text);
        }
    }
}

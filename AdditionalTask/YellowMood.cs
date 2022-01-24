using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    internal class YellowMood : Printer
    {
        //public YellowMood(string text) : base(text) { }
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Print();
        }

        public override void PrintText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.PrintText(text);
        }
    }
}

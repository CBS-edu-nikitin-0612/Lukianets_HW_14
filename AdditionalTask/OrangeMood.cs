using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    internal class OrangeMood : Printer
    {
        //public OrangeMood(string text) : base(text) { }
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print();
        }

        public override void PrintText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.PrintText(text);
        }
    }
}

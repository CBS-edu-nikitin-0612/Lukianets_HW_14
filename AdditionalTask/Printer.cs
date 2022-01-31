using System;

namespace AdditionalTask
{
    internal class Printer
    {
        protected string _text;
        protected readonly string defaultText = "R A I N B O W";
        public string Text
        {
            get => _text;
            set
            {
                if (value != null)
                    _text = value;
                else
                    Console.WriteLine("Wrong input");
            }
        }
        public Printer(string text)
        {
            Text = text;
        }
        public Printer()
        {
            Text = defaultText;
        }
        public virtual void Print()
        {
            Console.WriteLine(Text);
        }
        public virtual void PrintText(string text)
        {
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

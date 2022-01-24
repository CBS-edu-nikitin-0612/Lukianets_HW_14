using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {
        static void Main()
        {
            List<Printer> rainbow = new List<Printer>()
            {
                new RedMood(),
                new OrangeMood(),
                new YellowMood(),
                new GreenMood(),
                new BlueMood(),
                new IndigoMood(),
                new VioletMood()
            };
            foreach (Printer p in rainbow)
                p.Print();
            Console.WriteLine();

            foreach (Printer p in rainbow)
                p.PrintText("Text2");
            Console.WriteLine();

            RedMood announce = new RedMood();
            Printer printer1 = announce;
            printer1.PrintText("Print some important info");
            Console.WriteLine();

            (printer1 as Printer).PrintText("Still in RED");
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Enter the key to activate mode: pro/expert/ or sth else");
            string key = Console.ReadLine();

            DocumentWorker docWork1 = DocumentWorker.InitializeDocument(key);

            Console.WriteLine();
            docWork1.OpenDocument();
            docWork1.EditDocument();
            docWork1.SaveDocument();
            Console.WriteLine();
        }
    }
}

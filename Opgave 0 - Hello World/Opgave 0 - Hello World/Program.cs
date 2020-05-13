using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_0___Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave A
            Console.WriteLine("Halløj Verden!");

            //Opgave B
            Console.WriteLine("Hvad hedder du?");
            string name = Console.ReadLine();
            Console.WriteLine("Hej " + name);

            //Opgave C
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            //Den svarer med det parameter jeg skriver ind i cmd
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;

            Random dice = new Random();
            int rollDice = dice.Next(1,7);
            Console.WriteLine("du slog en " + rollDice+"'er");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_3___Løkker
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---For Loop---

            //for (int i = 100; i > 1; i--) //Loop 0-99. 100 tal
            //{
            //    if (i > 50) //Stopper loop ved 49. 50 tal
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // ---While Loop---

            //int i = 0;
            //while (i < 100)
            //{
            //    if (i<50)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            // ---For Loop 2 tabel---

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i * 2);
            }
        }
    }
}

using System;


namespace for_each_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numre = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($"Tryk for at liste tal fra 0 til 9");
            Console.ReadLine();
            foreach (int items in numre)
            {
                Console.WriteLine(items);
            }
        }
    }
}

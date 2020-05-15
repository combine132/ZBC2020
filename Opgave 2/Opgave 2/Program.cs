using System;

namespace Opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            string kast = Console.ReadLine();
            int kastInt = Convert.ToInt32(kast);
            int ones = 0, twos = 0, threes = 0, fours = 0, fives = 0, sixes = 0;
            for (int i = 0; i < kastInt; i++)
            {
                int rollDice = dice.Next(1, 7);
                Console.WriteLine($"{rollDice}");
                if (rollDice == 1)
                {
                    ones++;
                }
                if (rollDice == 2)
                {
                    twos++;
                }
                if (rollDice == 3)
                {
                    threes++;
                }
                if (rollDice == 4)
                {
                    fours++;
                }
                if (rollDice == 5)
                {
                    fives++;
                }
                if (rollDice == 6)
                {
                    sixes++;
                }
            }
            Console.WriteLine($"Total:\nOnes: {ones}\nTwos: {twos}\nThrees: {threes}\nFours: {fours}\nFives: {fives}\nSixes: {sixes}");
        }
    }
}

using System;

namespace guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            // definere guesses her da det ikke virker i den anden metode
            int guesses = 0;

            // CW til at fortælle brugeren hvad programmet er og gør
            Console.WriteLine($"Guess a number from 0 to 100!");

            // Kalder metoden
            GuessingGame(ref guesses);

            // hvis brugeren har vundet
            Console.WriteLine($"You made {guesses} guesses.\nTry guessing it in fewer guesses next time.");
        }

        // En rigtigt god metode som jeg selv har skrevet :)
        private static void GuessingGame(ref int amountOfGuesses)
        {
            // Opretter en Random som jeg konvertere til String fordi jeg er for dum til at bruge int
            Random rNumGen = new Random();
            int numToGuess = rNumGen.Next(101);
            string numToGuess2 = Convert.ToString(numToGuess);

            // boolean til at tjekke om brugeren har vundet
            bool AreYaWinningSon = false;

            // While loop, da det lige passede bedst
            while (AreYaWinningSon != true)
            {
                // ReadLine her, da den ellers ikke vil virke
                string guessStringNumber = Console.ReadLine();
                Int32.TryParse(guessStringNumber, out int guessedNumber);

                // Har brugeren gættet rigtigt?
                if (guessStringNumber == numToGuess2)
                {
                    AreYaWinningSon = true;
                    Console.WriteLine($"Correct, the number was {numToGuess}");
                }
                else
                {
                    if (guessedNumber > numToGuess)
                    {
                        Console.WriteLine($"The number is smaller than your guess.");
                    }
                    else if (guessedNumber < numToGuess)
                    {
                        Console.WriteLine($"The number is larger than your guess.");
                    }
                    // Tæller hvor mange gæt brugeren har brugt.
                    amountOfGuesses++;
                }
            }
        }
    }
}

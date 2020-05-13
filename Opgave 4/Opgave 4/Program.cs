using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Opgave A, B & C 
            /*
            int[] simon = {5,6,43,23};

            //for (int i = 0; i < simon.Length;)
            {
                if (simon[0] <= 5)
                {
                    Console.WriteLine(simon[0] + " letters? Pretty short name you have got there.");
                }
                else if (simon[0] >= 6)
                {
                    Console.WriteLine(simon[0] + " letters? Quite a long name.");
                }
                if (simon[1] <= 6)
                {
                    Console.WriteLine(simon[1] + " letters? That's a short last name.");
                }
                else if (simon[1] >= 7)
                {
                    Console.WriteLine(simon[1] + " letters? What a long last name you've got.");
                }
                if (simon[2] <= 39)
                {
                    Console.WriteLine(simon[2] + " shoe size? Haha, you have small feet.");
                }
                else if (simon[2] >= 40)
                {
                    Console.WriteLine(simon[2] + " shoe size? Damn bigfoot, how's it going");
                }
                if (simon[3] <= 21)
                {
                    Console.WriteLine(simon[3] + " years old? Pretty young. Nice.");
                }
                else if (simon[3] >= 22)
                {
                    Console.WriteLine(simon[3] + " years old? You're an old geezer, damn.");
                }
            } 
            */
            #endregion

            //Opgave D
            Random randGen = new Random();
            string[] people = {"Tore", "Peter", "Katie", "Andre"};
            string[] actions = {"stjæler mederne fra julemandens kane", "drikker snaps", "pakker gaver ind", "pakker kattekillinger ind", "spiser vaniljekranse"};
            string[] causes = {"julen står for døren", "der er ild i juletræet", "sneen daler blidt ned", "julefrokosten gik over gevir"};
            string who, who2, action, reason;
            while (true)
            {
                who = people[randGen.Next(0,people.Length)];
                who2 = people[randGen.Next(0, people.Length)];
                action = actions[randGen.Next(0, actions.Length)];
                reason = causes[randGen.Next(0, causes.Length)];

                Console.WriteLine($"{who} er sammen med {who2}. \nDe {action}, fordi {reason}.");
                Console.ReadKey(); //Bedre end ReadLine, da den registrere alle tastatur tryk
            }
        }
    }
}

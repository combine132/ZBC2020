using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Calculator v0.0.0.1\n+ Addition\n- Subtraction\n* Multiplication\n/ Division");
            string math = Console.ReadLine();
            Console.WriteLine($"\nInput numbers");
            string inpOne = Console.ReadLine();
            string inpTwo = Console.ReadLine();

            double NumOne = Convert.ToInt32(inpOne);
            double NumTwo = Convert.ToInt32(inpTwo);
            
            if (math == "+")
            {
                double result = Add(NumOne, NumTwo);
                Console.WriteLine(result);
            }
            else if (math == "-")
            {
                double result = Subs(NumOne, NumTwo);
                Console.WriteLine(result);
            }
            else if (math == "*")
            {
                double result = Mult(NumOne, NumTwo);
                Console.WriteLine(result);
            }
            else if (math == "/")
            {
                double result = Div(NumOne, NumTwo);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine($"Error\nPlease enter 1-4 only.");
            }
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subs(double a, double b)
        {
            return a - b;
        }

        public static double Mult(double a, double b)
        {
            return a * b;
        }

        public static double Div(double a, double b)
        {
            return a / b;
        }
    }
}

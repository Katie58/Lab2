using System;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool retry = true;

            while (retry)
            {
                Console.Clear();
                Dimensions(ref retry);
                retry = Retry(ref retry);
            }
            Exit();
        }

        public static void Dimensions(ref bool retry)
        {
            double input = 0;

            string[] find = new string[3] { "length", "width", "height" };
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!\n");
            List<KeyValuePair<string, double>> inM = new List<KeyValuePair<string, double>>();
            foreach (string measure in find)
            {
                Console.WriteLine("Enter {0}: ", measure);
                if (double.TryParse(Console.ReadLine(), out input) && input >= 0)
                {
                    inM.Add(new KeyValuePair<string, double>(measure, input));
                }
                else
                    Invalid(ref retry);
            }
            Console.WriteLine("\nPerimeter: {0}", 2 * (inM[0].Value + inM[1].Value));
            Console.WriteLine("\nArea: {0}", inM[0].Value * inM[1].Value);
            Console.WriteLine("\nVolume: {0}", inM[0].Value * inM[1].Value * inM[2].Value);
        }

        public static void Invalid(ref bool retry)
        {
            Console.WriteLine("\nERROR - Invalid User Input...");
        }

        public static Boolean Retry(ref bool retry)
        {
            Console.Write("\nContinue? (y/n): ");
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.Y)
            {
                return true;
            }
            else if (key == ConsoleKey.N)
            {
                Console.WriteLine("\nGoodbye, Press ESCAPE to Exit");
                return false;
            }
            else
            {
                Invalid(ref retry);
                Retry(ref retry);
            }
            return retry;
        }

        public static void Exit()
        {
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Exit();
            }
        }
    }
}//October 8, 2018 - revised October 15, 2018

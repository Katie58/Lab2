using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_NUMBER_2
{
    class Program
    {
        public static void Main(string[] args)
        {

            double input = 0;
            double length = 0;
            double width = 0;
            double height = 0;
            Boolean retry = true;

            while (retry)
            {
                Console.Clear();
                Directions();
                UserInputLength(ref retry, out length, ref input);
                UserInputWidth(ref retry, out width, ref input);
                UserInputHeight(ref retry, out height, ref input);
                MathArea(length, width);
                MathPerimeter(length, width);
                MathVolume(length, width, height);
                retry = Retry(ref retry);
            }
            Exit();
        }

        public static void Directions()
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!\n");
        }

        public static double UserInput(ref bool retry, out double input)
        {
            if (double.TryParse(Console.ReadLine(), out input) && input >= 0)
            {
                return input;
            }
            else
            {
                Invalid(ref retry);
                return input;
            }
        }

        public static double UserInputLength(ref bool retry, out double length, ref double input)
        {
            Console.WriteLine("Enter Length: ");
            UserInput(ref retry, out input);
            length = input;
            return length;
        }

        public static double UserInputWidth(ref bool retry, out double width, ref double input)
        {
            Console.WriteLine("Enter Width: ");
            UserInput(ref retry, out input);
            width = input;
            return width;
        }

        public static double UserInputHeight(ref bool retry, out double height, ref double input)
        {
            Console.WriteLine("Enter Height: ");
            UserInput(ref retry, out input);
            height = input;
            return height;
        }

        public static void MathArea(double length, double width)
        {
            double area = width * length;
            Console.WriteLine("Area: " + area);
        }

        public static void MathPerimeter(double length, double width)
        {
            double perimeter = 2 * (width + length);
            Console.WriteLine("Perimeter: " + perimeter);
        }

        public static void MathVolume(double length, double width, double height)
        {
            double volume = length * width * height;
            Console.WriteLine("Volume: " + volume);
        }

        public static void Invalid(ref bool retry)
        {
            Console.WriteLine("\nERROR - Invalid User Input...");
            Retry(ref retry);
        }

        public static Boolean Retry(ref bool retry)
        {
            Console.WriteLine("\nContinue? (y/n): ");
            char answer = Console.ReadKey().KeyChar;
            if (answer == 'y' || answer == 'Y')
            {
                return true;
            }
            else if(answer == 'n' || answer == 'N')
            {
                return false;
            }
            else
            {
                Invalid(ref retry);
                return false;
            }
        }

        public static void Exit()
        {
            Console.WriteLine("\nGoodbye, Press ESCAPE to Exit");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.ReadKey();
            }
        }
    }
}//October 8, 2018

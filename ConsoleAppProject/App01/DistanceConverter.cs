using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// The objective of this app is to convert units of measure interchangeably.
    /// </summary>
    /// <author>
    /// Mauro Duarte Nunes
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double MILES_IN_FEET = 0.000189393939;

        public const double METERS_IN_MILES = 1609.344;

        public const string MILES = "miles";

        public const string FEET = "feet";

        public const string METERS = "meters";

        private double miles;

        private double feet;

        private double meters;

        public void Run()
        {
            OutputHeading();
            InputChoice();
            OutputChoice();
        }
        /// <summary>
        /// Prompt user to enter the distance in miles.
        /// Input the miles as a double number.
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("       Distance Converter      ");
            Console.WriteLine("         by Mauro Nunes        ");
            Console.WriteLine("-------------------------------");
        }
        private void InputChoice()
        {
            Console.WriteLine("\nConvert from: ");
            Console.WriteLine("\n- Miles");
            Console.WriteLine("- Feet\n");
            string choice = Console.ReadLine();
            if (choice.Equals(MILES))
            {
                InputMiles();
            }
            else if (choice.Equals(FEET))
            {
                InputFeet();
            }
            else
            {
                Console.WriteLine("\nEnter one of the choices below");
                InputChoice();
            }
        }
        private void OutputChoice()
        {
            Console.WriteLine("Convert to: ");
            Console.WriteLine("\n- Miles");
            Console.WriteLine("- Feet");
            Console.WriteLine("- Meters\n");
            string choice = Console.ReadLine();
            if (choice.Equals(MILES))
            {
                CalculateMiles();
                OutputMiles();
            }
            else if (choice.Equals(FEET))
            {
                CalculateFeet();
                OutputFeet();
            }
            else if (choice.Equals(METERS))
            {
                CalculateMeters();
                OutputMeters();
            }
            else
            {
                Console.WriteLine("\nEnter one of the choices below\n");
                OutputChoice();
            }
        }
        private void InputMiles()
        {
            Console.Write("\nInput the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
            Console.WriteLine();
        }
        private void InputFeet()
        {
            Console.Write("\nInput the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
            Console.WriteLine();
        }
        /// <summary>
        /// Calculate the distance from the miles input to feet.
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }
        /// <summary>
        /// Calculate the distance from the feet input to miles.
        /// </summary>
        private void CalculateMiles()
        {
            miles = feet * MILES_IN_FEET;
        }
        /// <summary>
        /// Calculate the distance from the miles input to meters.
        /// </summary>
        private void CalculateMeters()
        {
            meters = miles * METERS_IN_MILES;
        }
        /// <summary>
        /// Output the converted feet.
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine("\n" + miles + " mile(s) is " + feet + " feet!");
        }
        /// <summary>
        /// Output the converted miles.
        /// </summary>
        private void OutputMiles()
        {
            Console.WriteLine("\n" + feet + " feet is " + miles + " mile(s)!");
        }
        /// <summary>
        /// Output the converted meters.
        /// </summary>
        private void OutputMeters()
        {
            Console.WriteLine("\n" + miles + " mile(s) is " + meters + " meter(s)!");
        }
    }
}

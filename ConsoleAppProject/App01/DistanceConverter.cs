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

        public const double METERS_IN_MILES = 1609.344;

        public const double FEET_IN_METERS = 3.2808399;

        public const string MILES = "miles";

        public const string FEET = "feet";

        public const string METERS = "meters";

        private double miles;

        private double feet;

        private double meters;

        /// <summary>
        /// Executes the program in the desired order, so as to make sure the correct information is displayed.
        /// </summary>
        public void Run()
        {
            OutputHeading();
            UnitChoice();
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
        }/// <summary>
        /// Control what methods are called based on the user's input.
        /// If the choice is not a number from 1-6, an error message is displayed.
        /// </summary>
        private void UnitChoice()
        {
            Console.WriteLine("\nWhat units would you like to convert?: ");
            Console.WriteLine("\n1. Miles to Feet");
            Console.WriteLine("2. Miles to Meters");
            Console.WriteLine("3. Feet to Miles");
            Console.WriteLine("4. Feet to Meters");
            Console.WriteLine("5. Meters to Miles");
            Console.WriteLine("6. Meters to Feet");
            Console.WriteLine();
            string choice = Console.ReadLine();
            if (choice.Equals("1"))
            {
                InputMiles();
                CalculateFeetFromMiles();
                OutputMilesToFeet();
            }
            else if (choice.Equals("2"))
            {
                InputMiles();
                CalculateMetersFromMiles();
                OutputMilesToMeters();
            }
            else if (choice.Equals("3"))
            {
                InputFeet();
                CalculateMilesFromFeet();
                OutputFeetToMiles();
            }
            else if (choice.Equals("4"))
            {
                InputFeet();
                CalculateMetersFromFeet();
                OutputFeetToMeters();
            }
            else if (choice.Equals("5"))
            {
                InputMeters();
                CalculateMilesFromMeters();
                OutputMetersToMiles();
            }
            else if (choice.Equals("6"))
            {
                InputMeters();
                CalculateFeetFromMeters();
                OutputMetersToFeet();
            }
            else
            {
                Console.WriteLine("\nEnter one of the choices below");
                UnitChoice();
            }
        }
        /// <summary>
        /// Prompt the user to input the number of miles to be converted.
        /// </summary>
        private void InputMiles()
        {
            Console.Write("\nInput the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        /// <summary>
        /// Prompt the user to input the number of feet to be converted.
        /// </summary>
        private void InputFeet()
        {
            Console.Write("\nInput the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }
        /// <summary>
        /// Prompt the user to input the number of meters to be converted.
        /// </summary>
        private void InputMeters()
        {
            Console.Write("\nInput the number of meters > ");
            string value = Console.ReadLine();
            meters = Convert.ToDouble(value);
        }
        /// <summary>
        /// Convert the number of miles input by the user to feet.
        /// </summary>
        private void CalculateFeetFromMiles()
        {
            feet = miles * FEET_IN_MILES;
        }
        /// <summary>
        /// Convert the number of feet input by the user to miles.
        /// </summary>
        private void CalculateMilesFromFeet()
        {
            miles = feet / FEET_IN_MILES;
        }
        /// <summary>
        /// Convert the number of miles input by the user to meters.
        /// </summary>
        private void CalculateMetersFromMiles()
        {
            meters = miles * METERS_IN_MILES;
        }
        /// <summary>
        /// Convert the number of feet input by the user to meters.
        /// </summary>
        private void CalculateMetersFromFeet()
        {
            meters = feet / FEET_IN_METERS;
        }
        /// <summary>
        /// Convert the number of meters input by the user to miles.
        /// </summary>
        private void CalculateMilesFromMeters()
        {
            miles = meters / METERS_IN_MILES;
        }
        /// <summary>
        /// Convert the number of meters input by the user to feet.
        /// </summary>
        private void CalculateFeetFromMeters()
        {
            feet = meters * FEET_IN_METERS;
        }
        /// <summary>
        /// Output the result from converting miles to feet.
        /// </summary>
        private void OutputMilesToFeet()
        {
            if (feet == 1)
            {
                Console.WriteLine("\n" + miles + " mile(s) is " + feet + " foot!");
            }
            else
            {
                Console.WriteLine("\n" + miles + " mile(s) is " + feet + " feet!");
            }
        }
        /// <summary>
        /// Output the result from converting feet to miles.
        /// </summary>
        private void OutputFeetToMiles()
        {
            if(feet == 1)
            {
                Console.WriteLine("\n" + feet + " foot is " + miles + " mile(s)!");
            }
            else
            {
                Console.WriteLine("\n" + feet + " feet is " + miles + " mile(s)!");
            }
        }
        /// <summary>
        /// Output the result from converting miles to meters.
        /// </summary>
        private void OutputMilesToMeters()
        {
            Console.WriteLine("\n" + miles + " mile(s) is " + meters + " meter(s)!");
        }
        /// <summary>
        /// Output the result from converting feet to meters.
        /// </summary>
        private void OutputFeetToMeters()
        {
            if(feet == 1)
            {
                Console.WriteLine("\n" + feet + " foot is " + meters + " meter(s)!");
            }
            else
            {
                Console.WriteLine("\n" + feet + " feet is " + meters + " meter(s)!");
            }
        }
        /// <summary>
        /// Output the result from converting meters to miles.
        /// </summary>
        private void OutputMetersToMiles()
        {
            Console.WriteLine("\n" + meters + " meter(s) is " + miles + " mile(s)!");
        }
        /// <summary>
        /// Output the result from converting meters to feet.
        /// </summary>
        private void OutputMetersToFeet()
        {
            if(feet == 1)
            {
                Console.WriteLine("\n" + meters + " meter(s) is " + feet + " foot!");
            }
            else
            {
                Console.WriteLine("\n" + meters + " meter(s) is " + feet + " feet!");
            }
        }
    }
}
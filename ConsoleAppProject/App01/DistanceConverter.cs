﻿using System;

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
        }
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
        private void InputMiles()
        {
            Console.Write("\nInput the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        private void InputFeet()
        {
            Console.Write("\nInput the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }
        private void InputMeters()
        {
            Console.Write("\nInput the number of meters > ");
            string value = Console.ReadLine();
            meters = Convert.ToDouble(value);
        }
        /// <summary>
        /// Calculate the distance from the miles input to feet.
        /// </summary>
        private void CalculateFeetFromMiles()
        {
            feet = miles * FEET_IN_MILES;
        }
        /// <summary>
        /// Calculate the distance from the feet input to miles.
        /// </summary>
        private void CalculateMilesFromFeet()
        {
            miles = feet / FEET_IN_MILES;
        }
        /// <summary>
        /// Calculate the distance from the miles input to meters.
        /// </summary>
        private void CalculateMetersFromMiles()
        {
            meters = miles * METERS_IN_MILES;
        }
        private void CalculateMetersFromFeet()
        {
            meters = feet / FEET_IN_METERS;
        }
        private void CalculateMilesFromMeters()
        {
            miles = meters / METERS_IN_MILES;
        }
        private void CalculateFeetFromMeters()
        {
            feet = meters * FEET_IN_METERS;
        }
        /// <summary>
        /// Output the converted feet.
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
        /// Output the converted miles.
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
        /// Output the converted meters.
        /// </summary>
        private void OutputMilesToMeters()
        {
            Console.WriteLine("\n" + miles + " mile(s) is " + meters + " meter(s)!");
        }
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
        private void OutputMetersToMiles()
        {
            Console.WriteLine("\n" + meters + " meter(s) is " + miles + " mile(s)!");
        }
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
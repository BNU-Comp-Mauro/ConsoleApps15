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
        private double miles;

        private double feet;

        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        /// <summary>
        /// Prompt user to enter the distance in miles.
        /// Input the miles as a double number.
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Input the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        /// <summary>
        /// Calculate the distance from the miles input to feet.
        /// </summary>
        private void CalculateFeet()
        {

        }
        /// <summary>
        /// Output the converted feet.
        /// </summary>
        private void OutputFeet()
        {

        }
    }
}

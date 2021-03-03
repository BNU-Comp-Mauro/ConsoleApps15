using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app serves as a BMI (Body Mass Index) calculator, by taking in height and weight as parameters.
    /// Values assigned according to WHO's standards.
    /// </summary>
    /// <author>
    /// Mauro Duarte Nunes
    /// 21815118
    /// 2/3/2021
    /// </author>
    public class BMI
    {
        private const string WEIGHT_IN_POUNDS = "pounds";

        private const string WEIGHT_IN_STONES = "stones";

        private const string HEIGHT_IN_FEET = "feet";

        private const string HEIGHT_IN_INCHES = "inches";

        private const string WEIGHT_IN_KILOS = "kilograms";

        private const string HEIGHT_IN_METERS = "meters";

        public double pounds;

        public double stones;

        public double feet;

        public double inches;

        public double kilos;

        public double meters;

        public void Run()
        {
            OutputHeading();
            UnitChoice();
        }
        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("   Body Mass Index Calculator ");
            Console.WriteLine("        by Mauro Nunes        ");
            Console.WriteLine("-------------------------------");
        }
        private void UnitChoice()
        {
            Console.WriteLine("\nWhat units would you like to enter?");
            Console.WriteLine("\n1. Metric Units");
            Console.WriteLine("2. Imperial Units");
            Console.WriteLine();
            string choice = Console.ReadLine();
            if (choice.Equals("1"))
            {
                InputMeters();
                InputKilos();
            }
            else if (choice.Equals("2"))
            {
                InputFeet();
                InputInches();
                InputPounds();
                InputStones();
            }
        }
        private void InputFeet()
        {
            Console.WriteLine("\nEnter your height to the nearest feet and inches");
            Console.Write("\nEnter your height in feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }
        private void InputInches()
        {
            Console.Write("Enter your height in inches > ");
            string value = Console.ReadLine();
            inches = Convert.ToDouble(value);
        }
        private void InputPounds()
        {
            Console.WriteLine("\nEnter your weight to the nearest pounds and stones");
            Console.Write("Enter your weight in stones > ");
            string value = Console.ReadLine();
            stones = Convert.ToDouble(value);
        }
        private void InputStones()
        {
            Console.Write("\nEnter your weight in pounds > ");
            string value = Console.ReadLine();
            pounds = Convert.ToDouble(value);
        }
        private void InputMeters()
        {
            Console.WriteLine("\nEnter your height to the nearest meters");
            Console.Write("\nEnter your height in meters > ");
            string value = Console.ReadLine();
            meters = Convert.ToDouble(value);
        }
        private void InputKilos()
        {
            Console.WriteLine("\nEnter your weight to the nearest kilograms");
            Console.Write("\nEnter your weight in kilograms > ");
            string value = Console.ReadLine();
            kilos = Convert.ToDouble(value);
        }
    }
}

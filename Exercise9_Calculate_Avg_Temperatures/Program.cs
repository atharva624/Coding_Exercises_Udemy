

//Create a simple C# program that calculates the average temperature from an array of temperatures. The program should:

//Declare a method CalculateAverage that takes an array of doubles as a parameter.

//Implement the method to calculate the average of the temperatures in the array.

//Declare a method PrintAverage that takes an array of doubles as a parameter.

//Implement the method to call CalculateAverage and print the result to the console.

//Alert!

//The result of execution for the default string should be:

//"The average temperature is: 23.5"

using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintAverage(double[] temperatures)
        {

            double res = CalculateAverage(temperatures);
            Console.WriteLine("The average temperature is: " + res);
        }

        public double CalculateAverage(double[] temperatures)
        {

            double res = 0;
            foreach (double temp in temperatures)
            {
                res += temp;

            }
            res = res / temperatures.Length;
            return res;
        }

        public static void Main()
        {
            Exercise exercise = new Exercise();
            double[] temperatures = { 24.5, 23.3, 30.3, 34.5, 31.3 };
            exercise.PrintAverage(temperatures);
        }
    }
}

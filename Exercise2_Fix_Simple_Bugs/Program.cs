//Create a C# program that correctly calculates and displays the average of three numbers. The provided code has several bugs that prevent it from compiling and running correctly.
//The result of execution for the default string should be:
//"The average is: 20"

using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void CalculateAverage()
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int average = (num1 + num2 + num3) / 3;
            Console.WriteLine("The average is: " + average);
        }
    public static void Main()
    {
        Exercise exercise = new Exercise();
        exercise.CalculateAverage();
    }
    }


}
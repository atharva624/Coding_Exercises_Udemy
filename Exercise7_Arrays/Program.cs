//Create a simple C# program that declares an array of integers, initializes it with values, and uses a foreach loop to print each value to the console.

//Alert!

//The result of execution for each default value should be printed on new lines as:

//1
//2
//3
//4
//5
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintNumbers()
        {
            // Initialize array and print each number using a foreach loop
            int[] num = { 1, 2, 3, 4, 5 };
            foreach (int n in num)
            {
                Console.WriteLine(n);
            }
        }

        public static void Main()
        {
            Exercise exercise = new Exercise();
            exercise.PrintNumbers();
        }
    }
}

//Create a simple C# program that declares a list of integers, initializes it with the values 1, 2, and 3, and prints each value to the console.  Loop through the collection and print each number out followed by a space.

//Alert!

//The result of execution for the default string should be:

//"1 2 3 "

using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintNumbers()
        {
            // TODO
            List<int> list = new List<int> { 1, 2, 3 };
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
        }
        public static void Main(string[] args)
        {
            // TODO: Call DoubleValue and print the result
            Exercise exercise = new Exercise();
            exercise.PrintNumbers();

        }
    }
}


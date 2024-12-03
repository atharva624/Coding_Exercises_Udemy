//Create a simple C# program that demonstrates the use of the finally block. The program should:

//Declare a method PrintWithFinally which contains a try block that writes "Trying..." to the console.

//Add a finally block that writes "Finally executed." to the console.

//Ensure the finally block executes even if the try block does not throw an exception.

//Alert!

//The result of execution for the default string should be:

//"Trying..." "Finally executed."

using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintWithFinally()
        {
            // TODO
            try
            {
                Console.WriteLine("Trying...");
            }
            finally
            {
                Console.WriteLine("Finally executed.");
            }
        }
        public static void Main(string[] args)
        {
            // TODO: Call DoubleValue and print the result
            Exercise exercise = new Exercise();
            exercise.PrintWithFinally();

        }
    }
}


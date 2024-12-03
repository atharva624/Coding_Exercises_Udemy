//Create a simple C# program that declares a static method which takes an integer as a parameter, doubles it, and returns the result. Call this static method from the Main method and print the result to the console.

//Alert!

//The result of execution for the default integer should be:

//"20"

using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int DoubleValue(int number)
        {
            // TODO: Implement the method to double the value
            return 2 * number;
        }

        public static void Main(string[] args)
        {
            // TODO: Call DoubleValue and print the result
            int num = 10;
            int result = DoubleValue(num);
            Console.WriteLine(result);
        }

       
    }
}

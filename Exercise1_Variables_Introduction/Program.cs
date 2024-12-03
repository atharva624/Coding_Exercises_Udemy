using System;

//Create a simple C# program that declares an integer variable, assigns it the value 10, and prints the value to the console.
//The result of execution for the default string should be:
//"10"

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintNumber()
        {
            int temp = 10;

            Console.WriteLine(temp);
        }

        public static void Main()
        {
           Exercise exercise = new Exercise();
           exercise.PrintNumber();
        }
    
    }


}

using System;
//Using the Switch Statement
//Please, avoid changing the given source code for the exercise! So only add code, don't modify unless it is instructed to do so!
//#########################################
//Create a simple C# program using a switch statement to replace an if-else structure for printing days of the week based on an integer value.
//Alert!
//The result of execution for the default string should be:
//"Wednesday"
namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintDay()
        {
            int day = 3;

            // TODO: Rewrite this if-else structure using a switch statement.
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Another day");
                    break;
            }

        }
        public static void Main()
        {
            Exercise exercise = new Exercise();
            exercise.PrintDay();
        }
    }
}

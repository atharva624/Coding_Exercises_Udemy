//using System.Collections.Generic;

//Create a list of integers with values { 1, 6, 3 }. Use the Any method to check if any element in the list is greater than 5, and print "True" or "False" based on the result.

//Note: The list { 1, 6, 3 } is the default list you should use for this exercise. You don't need to modify the initial code structure—just add the list declaration and logic to check and print the result.

//Alert!

//The result of execution for the default list should be:

//"True"

using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void CheckAny()
        {
            // The list has been declared for you, use it in your solution.
            List<int> myNumbers = new List<int> { 1, 6, 3 };

            bool res = myNumbers.Any(X => X > 5);
            Console.WriteLine(res);

            // TODO: Check if any number is greater than 5 using the Any method
            // and print the result ("True" or "False") to the console.
        }

        public static void Main(string[] args)
        {
            // TODO: Call DoubleValue and print the result
            Exercise exercise = new Exercise();
            exercise.CheckAny();

        }
    }
}

//using System.ComponentModel;

//Create a simple C# program that demonstrates handling multiple types of exceptions. The program should:

//Declare a method HandleMultipleExceptions which:

//Takes a string  and an int as parameters, in that order.

//Contains a local int[] variable with predefined elements, for example, int[] numbers = { 1, 2, 3 };.

//Contains a try block where you:

//Attempt to parse an integer from the string parameter that could throw a FormatException.

//Access an element in the array by the integer parameter as an index that could throw an IndexOutOfRangeException.

//Catch and handle both FormatException and IndexOutOfRangeException.

//Print specific messages for each exception type.
//The result of execution should be:

//If a FormatException occurs: "Invalid format."

//If an IndexOutOfRangeException occurs: "Index out of range."

//If no exception occurs: the accessed array element.

//Example output for no exception: "2"

//Example output for FormatException: "Invalid format."

//Example output for IndexOutOfRangeException: "Index out of range."
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void HandleMultipleExceptions(string input, int index)
        {
            // TODO
            int[] numbers = { 1, 2, 3 };
            try
            {
                int parsedNumber = int.Parse(input);
                Console.WriteLine(numbers[index]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }

        }
        public static void Main(string[] args)
        {
            // TODO: Call DoubleValue and print the result
            Exercise exercise = new Exercise();
            exercise.HandleMultipleExceptions("123", 1);  // Should print "2"
            exercise.HandleMultipleExceptions("abc", 1);  // Should print "Invalid format."
            exercise.HandleMultipleExceptions("123", 5);

        }
    }
}

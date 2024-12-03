//Create a simple C# program that demonstrates the use of regex to extract email addresses from a string. The program should:

//Define a method ExtractPatterns in the Exercise class.

//The ExtractPatterns method should take a string input as a parameter.

//Use a regular expression to match all email addresses in the input string.

//Print each matched email address to the console.

//Alert!

//The result of execution should show the email addresses extracted from the input string printed to the console.

//Example:

//For an input string: "Contact us at support@example.com or sales@example.org.", the output should be:

//support @example.com
//sales@example.org
using System;
using System.Text.RegularExpressions;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void ExtractPatterns(string input)
        {
            // TODO: Implement the method to extract and print email addresses using regex
            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }
         public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.ExtractPatterns("Contact us at support@example.com or sales@example.org.");

        }
    }
}

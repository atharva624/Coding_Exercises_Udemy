
//Exercise: DataType Bool and Conditional Statements

//INSTRUCTIONS:

//Please, avoid changing the given source code for the exercise! Only add code, do not modify unless instructed to do so!

//#########################################

//Create a simple C# program that uses a boolean variable to store whether a user is logged in and prints different messages based on the value. The final output must be "Welcome back!"

//Alert!

//The result of execution for the default string should be:

//"Welcome back!"

using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void CheckLogin()
        {
            bool isLoggedIn = false;

            // Assign a value to isLoggedIn based on user input or condition

            if (!isLoggedIn)
            {
                Console.WriteLine("Welcome back!");
            }
            else
            {
                Console.WriteLine("Please log in.");
            }
        }

        public static void Main()
        {
            Exercise exercise = new Exercise();
            exercise.CheckLogin();
        }
    }
}

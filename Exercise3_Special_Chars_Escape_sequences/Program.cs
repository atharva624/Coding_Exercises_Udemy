using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintSpecialCharacters()
        {
            string s = "Hello\n\tWorld!";
            Console.WriteLine(s);
        }

        public static void Main()
        {
            Exercise exercise = new Exercise();
            exercise.PrintSpecialCharacters();
        }
    }
}

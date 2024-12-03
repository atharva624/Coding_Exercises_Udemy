//Create a simple C# program that initializes a 3x3 two-dimensional array with integers, calculates the sum of each row, and prints the sums to the console.

//The program should:

//Declare and initialize a 3x3 two-dimensional array with the following values:

//1 2 3
//4 5 6
//7 8 9
//Calculate the sum of each row in the array.

//Print the sum of each row to the console.

//Alert!

//The result of execution for the default string should be:

//6
//15
//24
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintRowSums()
        {
            // TODO
            int[,] arr = {{1,2,3},
            {4,5,6},
            {7,8,9}
            };

            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum += arr[i, j];

                }
                Console.WriteLine(sum);
            }
        }

        public static void Main()
        {
            Exercise exercise = new Exercise();
            exercise.PrintRowSums();
        }
    }

}

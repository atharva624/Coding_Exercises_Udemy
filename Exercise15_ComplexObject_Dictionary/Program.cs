//using System.Diagnostics.Metrics;

//Using a Complex Object as the Value of a Dictionary
//#########################################
//Please, avoid changing the given source code for the exercise! So only add code, don't modify unless it is instructed to do so!
//#########################################
//Create a simple C# program that declares a dictionary with string keys and values of type List<int>, initializes it with one key-value pair, and prints the values of the list for the given key to the console.
//Alert!
//The result of execution for the default string should be:
//"1 2 3 "(Plus a space after the "3")

using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintDictionaryValues()
        {
            // TODO
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            dict["key1"] = new List<int> { 1, 2, 3 };
            if (dict.ContainsKey("key1"))
            {
                List<int> temp = dict["key1"];
                foreach (int num in temp)
                {
                    Console.Write(num + " ");
                }
            }
        }
        public static void Main(string[] args)
        {
            // TODO: Call DoubleValue and print the result
            Exercise exercise = new Exercise();
            exercise.PrintDictionaryValues();

        }
    }
}


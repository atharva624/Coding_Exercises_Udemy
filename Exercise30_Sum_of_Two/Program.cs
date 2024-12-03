//This time you have to write a method that will take two arguments: a list of integers nums and an integer SumToFind. And it returns the number of possible UNIQUE pares made from this list where the sum equals to SumToFind
//Example:
//SumOfTwo([1, 1, 1, 2, 3, 4, 5, 2], 2)
//It should return: 1
//Explanation: there is only one pair sum of witch is equal to 2 (1,1)
using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int SumOfTwo(int[] nums, int SumToFind)
        {
            // todo
            HashSet<int> seenNumbers = new HashSet<int>();
            HashSet<string> uniquePairs = new HashSet<string>();

            foreach (var num in nums)
            {
                int complement = SumToFind - num;

                if (seenNumbers.Contains(complement))
                {
                    var pair = num < complement ? $"{num},{complement}" : $"{complement},{num}";
                    uniquePairs.Add(pair);
                }

                seenNumbers.Add(num);
            }

            return uniquePairs.Count;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(SumOfTwo(new int[] { 1, 1, 1, 2, 3, 4, 5, 2 }, 2));

        }
    }

}

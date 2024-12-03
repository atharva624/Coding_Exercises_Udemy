//"Interview questions" is a pressing topic.That is why we decided to start with kittens 😸😸😸😸
//So imagine you are in a kitchen that is full of cats. Every typical hungry cat will follow you if you hold some food, right?
//Our goal is to count not hungry cats in the kitchen.
//You with food in the kitchen will be marked as F
//Every cat will be represented as ~O or O~ depending on the direction.
//Examples:
//Input: "~O~O~O~O F"
//Return: 0(all cats follow you)
//Input: "O~~O~O~O F O~O~"
//Return: 1(one is not following)
using System;


namespace Coding.Exercise
{
    public class Exercise
    {
        public int NotHungryCats(string kitchen)
        {
            kitchen = kitchen.Replace(" ", "");
            string[] cats = kitchen.Split('F');
            string left = cats[0];
            string right = cats[1];
            int count = 0;

            for (int i = 0; i < left.Length; i += 2)
            {
                if (left[i] == 'O')
                {
                    count++;
                }
            }

            for (int i = 0; i < right.Length; i += 2)
            {
                if (right[i] == '~')
                {
                    count++;
                }
            }

            return count;

        }
        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            //exercise.ExtractPatterns("Contact us at support@example.com or sales@example.org.");


            Console.WriteLine(exercise.NotHungryCats("O~~O~O~O F O~O~"));

        }
    }
}
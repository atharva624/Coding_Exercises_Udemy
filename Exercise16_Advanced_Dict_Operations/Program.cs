//using System.Reflection.Metadata;

//Create a C# program that declares a dictionary where the key is a string and the value is a custom object. The program should:

//Define a class Student with properties Id, Name, and Grade.

//Initialize a dictionary with keys as student names and values as Student objects.

//Add at least three Student objects to the dictionary.

//Iterate through the dictionary and print each student's details to the console.

//Alert!

//The result of execution for the default string should be:

//Name: John, Id: 1, Grade: 85
//Name: Alice, Id: 2, Grade: 90
//Name: Bob, Id: 3, Grade: 78
using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintStudents()
        {
            Dictionary<string, Student> dict = new Dictionary<string, Student>();

            dict.Add("John", new Student(1, "John", 85));
            dict.Add("Alice", new Student(2, "Alice", 90));
            dict.Add("Bob", new Student(3, "Bob", 78));

            foreach (var entry in dict)
            {
                var student = entry.Value;
                Console.WriteLine($"Name: {student.Name}, Id: {student.Id}, Grade: {student.Grade}");
            }
        }
        public static void Main(string[] args)
        {
            // TODO: Call DoubleValue and print the result
            Exercise exercise = new Exercise();
            exercise.PrintStudents();

        }
    }

    public class Student
    {
        // int Id;
        // string Name;
        // int Grade;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public Student(int id, string name, int grade)
        {
            // TODO
            Id = id;
            Name = name;
            Grade = grade;
        }
    }
}

//Create a simple C# program that demonstrates constructor inheritance. Define a base class Person with a constructor that takes a name and prints a message. Then, create a derived class Employee that calls the base class constructor and adds additional functionality. Print the messages to the console.

//Alert!

//The result of execution should be:

//"Person constructor: John Doe" "Employee constructor: John Doe, ID: 123"

using System;

namespace Coding.Exercise
{
    public class Person
    {
        // TODO: Declare a constructor that takes a name and prints a message
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
            Console.WriteLine($"Person constructor: {name}");
        }
    }

    public class Employee : Person
    {
        public int ID { get; set; }
        // TODO: Declare a constructor that takes a name and an ID, and calls the base class constructor
        public Employee(string name, int id) : base(name)
        {
            ID = id;
            Console.WriteLine($"Employee constructor: {name}, ID: {id}");
        }
    }

    public class Exercise
    {
        public void PrintMessages()
        {
            // TODO: Create an instance of Employee and print the messages
            Employee e = new Employee("John Doe", 123);

        }

        public static void Main(string[] args)
        {
            // TODO: Call DoubleValue and print the result
            Exercise exercise = new Exercise();
            exercise.PrintMessages();

        }
    }
}


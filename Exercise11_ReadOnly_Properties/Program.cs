//Create a simple C# program that declares a class with a private readonly field and a public read-only property to access it. The class should have a constructor that initializes the readonly field. Create an instance of the class and print the value of the read-only property to the console.

//Alert!

//The result of execution for the default string should be:

//"Read-Only Property Value"

using System;

namespace Coding.Exercise
{
    public class MyClass
    {
        // TODO: Declare a private readonly field to store the value
        private readonly string str;
        // TODO: Create a public read-only property to expose the field's value

        public MyClass(string value)
        {
            // TODO: Initialize the readonly field with the value parameter
            str = value;

        }
        public string ReadOnlyValue
        {
            get { return str; }
        }

    }

    public class Exercise
    {
        public void PrintReadOnlyProperty()
        {
            // TODO: Create an instance of MyClass with the value "Read-Only Property Value"
            // TODO: Print the value of the read-only property to the console
            MyClass obj = new MyClass("Read-Only Property Value");
            Console.WriteLine(obj.ReadOnlyValue);
        }

        public static void Main(string[] args)
        {
            // TODO: Call DoubleValue and print the result
            Exercise exercise = new Exercise();
            exercise.PrintReadOnlyProperty();

        }
    }
}

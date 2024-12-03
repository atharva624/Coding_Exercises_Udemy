//using System.Xml.Linq;

//Create a simple C# program that:

//Declares a class Person with the following:

//A private member variable _name of type string.

//A public property Name with a getter and setter to access _name.

//A private member variable _age of type int.

//A public property Age with a getter and a custom setter that only sets _age if the value is greater than 0.

//Adds a constructor to Person that takes two parameters, name and age, and initializes the member variables.

//Adds a method Greet that prints a greeting message including the person's name and age.

//Demonstrates the use of the class in the Main method by creating an instance of Person and calling the Greet method.

//Alert!

//The result of execution for the default string should be:

//"Hello, my name is John and I am 30 years old."

using System;

namespace Coding.Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TODO
            Person p = new Person("John", 30);
            p.Greet();
        }

    }
      

    public class Person
    {
        // TODO
        private string _name;
        private int _age;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    _age = 0;
                }

            }
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {_name} and I am {_age} years old.");
        }

        public Person(string name, int age)
        {
            _name = name;
            if (age > 0)
            {
                _age = age;
            }
        }

    }
}

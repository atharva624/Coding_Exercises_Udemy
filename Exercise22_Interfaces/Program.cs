//Create a simple C# program that demonstrates the implementation and use of interfaces. Define an interface IVehicle with a method Drive. Then, create a class Car that implements this interface and provides an implementation for the Drive method. Print a message to the console from the Drive method.

//Alert!

//The result of execution should be:

//"Car is driving"
using System;

namespace Coding.Exercise
{
    public interface IVehicle
    {
        // TODO: Declare a method Drive
        public void Drive();

    }

    public class Car : IVehicle
    {
        // TODO: Implement the Drive method
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }

    public class Exercise
    {
        public void TestDrive()
        {
            // TODO: Create an instance of Car and call the Drive method
            Car c = new Car();
            c.Drive();
        }

        public static void Main(string[] args)
        {
            // TODO: Call DoubleValue and print the result
            Exercise exercise = new Exercise();
            exercise.TestDrive();

        }
    }
}


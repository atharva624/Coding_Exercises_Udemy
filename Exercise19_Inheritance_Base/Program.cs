
//Create a simple C# program that demonstrates inheritance. Define a base class Animal with a MakeSound method. Then, create a derived class Dog that overrides the MakeSound method. Use the base keyword to call the base class method within the derived class method. Print the sounds to the console.

//Alert!

//The result of execution should be:

//"Animal sound" "Dog barks"
using System;

namespace Coding.Exercise
{
    public class Animal
    {
        // TODO: Declare a virtual method MakeSound
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }

    public class Dog : Animal
    {
        // TODO: Override the MakeSound method
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Dog barks");
        }
    }

    public class Exercise
    {
        public void PrintSounds()
        {
            // TODO: Create an instance of Dog and call the MakeSound method
            Dog d = new Dog();
            d.MakeSound();
        }

        public static void Main(string[] args)
        {
            // TODO: Call DoubleValue and print the result
            Exercise exercise = new Exercise();
            exercise.PrintSounds();

        }
    }
}


//Create a C# program that demonstrates method overriding using the override and virtual keywords. The program should:

//Declare a base class Animal with a virtual method MakeSound that prints "Animal makes a sound".

//Declare a derived class Dog that overrides the MakeSound method to print "Dog barks".

//Declare another derived class Cat that overrides the MakeSound method to print "Cat meows".

//Create instances of Animal, Dog, and Cat, and call the MakeSound method on each instance to demonstrate method overriding.

//Alert!

//The result of execution for the default string should be:

//"Animal makes a sound" "Dog barks" "Cat meows"
using System;

namespace Coding.Exercise
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    public class Exercise
    {
        public void DemonstrateOverriding()
        {
            // TODO
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();


            animal.MakeSound();  
            dog.MakeSound();     
            cat.MakeSound();
        }
        public static void Main(string[] args)
        {
            // TODO: Call DoubleValue and print the result
            Exercise exercise = new Exercise();
            exercise.DemonstrateOverriding();

        }
    }
}

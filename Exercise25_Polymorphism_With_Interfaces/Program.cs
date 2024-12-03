//Create a simple C# program that demonstrates polymorphism using interfaces. The program should:

//Declare an interface IShape with a method double GetArea().

//Create two classes, Circle and Rectangle, that implement the IShape interface.

//The Circle class should have a constructor that takes a radius and implements the GetArea method to return the area of the circle.

//The Rectangle class should have a constructor that takes width and height, and implements the GetArea method to return the area of the rectangle.

//In the PrintAreas method, create an array of IShape containing instances of Circle and Rectangle, and print the area of each shape to the console.

//Alert!

//The result of execution should be the area of each shape printed to the console.

//Example:

//For a Circle with radius 5 and a Rectangle with width 4 and height 6, the output should be:

//Area: 78.53981633974483\nArea: 24\n
using System;

namespace Coding.Exercise
{
    public interface IShape
    {
        double GetArea();
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;  
        }
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public double GetArea()
        {
            return Width * Height;  
        }
    }

    public class Exercise
    {
        public void PrintAreas()
        {
            // TODO: Add your code here
            IShape[] shapes = new IShape[]{
                new Circle(5),
                new Rectangle(4, 6)
            };

            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"Area: {shape.GetArea()}");
            }
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintAreas();

        }
    }
}

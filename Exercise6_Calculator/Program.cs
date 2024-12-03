using System;

//Create a simple C# calculator program that performs basic arithmetic operations (+, -, *, /) based on user input. The program should:
//Prompt the user to enter two numbers.
//Prompt the user to choose an arithmetic operation (Addition, Subtraction, Multiplication, Division).
//Use conditional statements to perform the selected operation.
//Print the result of the operation to the console.
//Handle division by zero with a specific message.
//Alert!
//The program should correctly handle and display the results of the operations, as well as handle invalid operations and division by zero.

namespace Coding.Exercise
{
    public class Exercise
    {
        public void SimpleCalculator()
        {
            // TODO: Implement the calculator logic here


            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose an operation: +, -, *, /");
            string operation = Console.ReadLine();

            double res;
            switch (operation)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine($"Result: {res}");
                    break;
                case "-":
                    res = num1 - num2;
                    Console.WriteLine($"Result: {res}");
                    break;
                case "*":
                    res = num1 * num2;
                    Console.WriteLine($"Result: {res}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        res = num1 / num2;
                        Console.WriteLine($"Result: {res}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                    break;
            }
        }
        public static void Main()
        {
            Exercise exercise = new Exercise();
            exercise.SimpleCalculator();
        }

    }
}

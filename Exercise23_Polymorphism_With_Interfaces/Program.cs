//Create a simple C# program that demonstrates polymorphism using interfaces. Define an interface IPayment with a method ProcessPayment. Then, create two classes CreditCardPayment and PayPalPayment that implement this interface and provide their own implementations for the ProcessPayment method. Use polymorphism to call the ProcessPayment method on instances of both classes.

//Alert!

//The result of execution should be:

//"Processing credit card payment" "Processing PayPal payment"
using System;

namespace Coding.Exercise
{
    public interface IPayment
    {
        // TODO: Declare a method ProcessPayment
        public void ProcessPayment();
    }

    public class CreditCardPayment : IPayment
    {
        // TODO: Implement the ProcessPayment method
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment");
        }
    }

    public class PayPalPayment : IPayment
    {
        // TODO: Implement the ProcessPayment method
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment");
        }

    }

    public class Exercise
    {
        public void ProcessPayments()
        {
            IPayment creditCard = new CreditCardPayment();
            IPayment payPal = new PayPalPayment();
            creditCard.ProcessPayment();
            payPal.ProcessPayment();
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.ProcessPayments();

        }
    }
}


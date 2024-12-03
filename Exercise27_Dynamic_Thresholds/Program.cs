//using System.Buffers.Text;
//using System.Collections.Generic;
//using System.Reflection;
//using System.Threading.Channels;
//using System;

//Create an advanced stock price monitoring system in C# that demonstrates the use of delegates and events with dynamic thresholds. The program should:

//Define a delegate StockPriceChangedHandler that takes a string message as a parameter.

//Create a class Stock with:

//An event OnStockPriceChanged of type StockPriceChangedHandler.

//A private field _price of type decimal.

//A private field _threshold of type decimal.

//A property Price with a getter and setter. The setter should raise the event if the price drops below the threshold.

//A property Threshold with a getter and setter to dynamically set the alert threshold.

//A method RaiseStockPriceChangedEvent that raises the event with the appropriate message.

//Define a subscriber class StockAlert with a method OnStockPriceChanged that prints the alert message to the console.

//In the Program class:
//Instantiate the Stock and StockAlert classes.

//Subscribe the StockAlert method to the Stock event.

//Set a dynamic threshold and simulate stock price changes to trigger the alert.
//Alert!

//The result of execution should show stock price alerts based on the dynamically set threshold printed to the console.

//Example:

//For a threshold of 120 and stock prices of 150, 130, 110, the output should be:

//scssCopy code(No alert for 150)
//(No alert for 130)
//Stock Alert: Stock price is below threshold!
using System; // Importing the System namespace

namespace Coding.Exercise // Defining the Coding.Exercise namespace
{
    // Define the delegate that will be used for the event
    public delegate void StockPriceChangedHandler(string message);

    // Define the Stock class which includes the event system
    public class Stock
    {
        // Declare the event using the delegate
        // Private field to store the stock price
        // Private field to store the threshold
        //TODO
        public event StockPriceChangedHandler OnStockPriceChanged;
        private decimal _price;
        private decimal _threshold;


        // Property to get and set the stock price
        public decimal Price
        {
            // Set the new price
            // Raise the event if the price drops below the threshold
            //TODO
            get { return _price; }
            set
            {
                _price = value;
                if (_price < _threshold)
                {
                    RaiseStockPriceChangedEvent("Stock Alert: Stock price is below threshold!");
                }
                else
                {
                    Console.WriteLine($"No alert for {Price}");
                }
            }

        }

        // Property to get and set the alert threshold
        public decimal Threshold
        {
            //TODO
            get { return _threshold; }
            set { _threshold = value; }
        }

        // Method to raise the stock price changed event
        protected virtual void RaiseStockPriceChangedEvent(string message)
        {
            // Invoke the event
            //TODO
            OnStockPriceChanged?.Invoke(message);
        }
    }

    // Define the subscriber class which reacts to the event
    public class StockAlert
    {
        // Method that handles the event and prints a message to the console
        //TODO
        public void OnStockPriceChanged(string message)
        {
            Console.WriteLine(message);
        }
    }

    // Program class to simulate the stock price changes and test the event system
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Stock and StockAlert
            //TODO

            // Subscribe to the stock price changed event
            //TODO

            // Set the alert threshold
            //TODO

            // Simulate stock price changes
            //TODO

            // Wait for user input to close the console
            //TODO
            Stock stock = new Stock();
            StockAlert alert = new StockAlert();

            stock.OnStockPriceChanged += alert.OnStockPriceChanged;

            stock.Threshold = 120;

            decimal[] prices = { 150, 130, 110 };
            foreach (var price in prices)
            {
                stock.Price = price;
            }

            Console.ReadLine();
        }
    }
}

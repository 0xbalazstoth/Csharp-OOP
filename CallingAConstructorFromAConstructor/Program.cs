using System;

namespace CallingAConstructorFromAConstructor
{
    // VendingMachine class
    class VendingMachine
    {
        // Private Fields
        private string _count;
        private string _capacity;
        private string _moneyCollected;

        // Default Constructor
        public VendingMachine()
        {

            this._count = "";
            this._capacity = "";
            this._moneyCollected = "";
        }

        // Parameterized Constructor 1
        public VendingMachine(string count, string capacity)
        {

            this._count = count;
            this._capacity = capacity;
        }

        // Parameterized Constructor 2
        // Write your code to modify the below constructor 
        public VendingMachine(string count, string capacity, string money) :this(count, capacity)
        {
            this._moneyCollected = money;
        }

        // Method to return vending machine details
        public string GetDetails()
        {

            return this._count + ", " + this._capacity + ", " + this._moneyCollected;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendy = new VendingMachine("Count: 45", "Capacity: 50", "Money Collected: 440$");
            Console.WriteLine(vendy.GetDetails());
        }
    }
}

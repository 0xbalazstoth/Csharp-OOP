using System;

namespace AccessingTheClassMembers
{
    class VendingMachine
    {
        // Class fields
        public int Count = 30;
        public int Capacity = 100;
        public int MoneyCollected = 300;
        public string Manufacturer = "Vendy";

        // Class methods
        public void Display()
        {
            Console.WriteLine("Display");
        }

        public void DispenseProducts()
        {
            Console.WriteLine("Dispense");
        }

        public void Refill()
        {
            Console.WriteLine("Refill");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.Display();
            Console.WriteLine(vendingMachine.Capacity);
        }
    }
}

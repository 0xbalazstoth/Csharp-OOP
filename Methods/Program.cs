using System;

namespace Methods
{
    class VendingMachine
    {
        public void Buy(string product)
        {
            Console.WriteLine($"You bought: {product}");
        }

        string manufacturer = "Vendy";
        public string GetManufacturer()
        {
            return manufacturer; // return statemenet
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //VendingMachine vendingMachine = new VendingMachine();
            //vendingMachine.Buy("Chocolate");

            //Console.WriteLine(vendingMachine.GetManufacturer());

            Calculator calculator = new Calculator();
            double x = 10;
            double y = 20;
            double z = 6;

            int a = 12;
            int b = 4;

            Console.WriteLine(calculator.Product(x, y));
            Console.WriteLine(calculator.Product(x, y, z));
            Console.WriteLine(calculator.Product(a, b));
        }
    }
}

using System;

namespace Protected
{
    /*
        The accessibility of the members declared with the
        protected access modifier is limited to the class
        containing it and the classes which derived from this
        class.
     */
    class Product
    {
        protected double price = 50;

        protected void Print()
        {
            Console.WriteLine("Print() method from Product class");
        }
    }

    class Beverage : Product
    {
        public void Access()
        {
            Console.WriteLine($"I can Access price: {price}");
            Print();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Beverage cola = new Beverage();
            cola.Access();
        }
    }
}

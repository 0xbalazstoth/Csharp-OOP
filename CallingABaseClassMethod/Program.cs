using System;

namespace CallingABaseClassMethod
{
    /*
        As with fields, base is also used with methods.
        Whenever a base class and the immediate derived class
        have methods with the same name, we use base to access
        the methods from the base class inside the derived class.
     */
    class Product
    {
        public void Display()
        {
            Console.WriteLine("From Product class!");
        }
    }

    class Beverage : Product
    {
        new public void Display()
        {
            Console.WriteLine("From Beverage class!");
        }

        public void PrintOut()
        {
            Console.WriteLine("The Display() call with base:");
            base.Display(); // Calling the Display() of Product(base class)
            Console.WriteLine("The Display() call without base:");
            Display(); // Calling the Display() of the Beverage(derived class)
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Beverage cola = new Beverage();
            cola.PrintOut();
        }
    }
}

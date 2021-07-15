using System;

namespace AccessingBaseClassFields
{
    class Product
    {
        public double price = 1.7;
    }

    class Beverage : Product
    {
        new double price = 1; //price field inside derived class

        public void Display()
        {
            //accessing the field of parent class using base*/
            Console.WriteLine("Price from the Product class: " + base.price);
            //without using base the field of current class shadows the field of parant class*/
            Console.WriteLine("Price from the Beverage class: " + this.price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Beverage cola = new Beverage();
            cola.Display();
        }
    }
}

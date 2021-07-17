using System;

namespace Abs_MultipleInheritance
{
    abstract class Beverage
    {
        private string _name;
        private int _price;

        protected Beverage(string name, int price)
        {
            _name = name;
            _price = price;
        }

        public int Price
        {
            get
            {
                return this._price;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
        }
    }

    interface IEnergyDrink
    {
        int CalculatePrice(int price);
    }

    class RedBull : Beverage, IEnergyDrink
    {
        public RedBull(int price) : base("RedBull", price)
        { }

        public int CalculatePrice(int price)
        {
            return (base.Price + 1);
        }

        public void PrintDetails()
        {
            Console.WriteLine("The name of the drink is: " + base.Name);
            Console.WriteLine("The price of the drink is: " + (CalculatePrice(base.Price)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RedBull redbull = new RedBull(5);
            redbull.PrintDetails();
        }
    }
}

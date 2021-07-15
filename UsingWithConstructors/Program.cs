using System;

namespace UsingWithConstructors
{
    /*
        In a constructor we can include a call to
        base() or this() but not both. Also, these calls can
        only be made after a constructor’s signature and before
        the start of curly brackets
     */
    class Product
    {
        private string _name;
        private double _price;
        private string _expiryDate;

        public Product(string name, double price, string expiryDate)
        {
            this._name = name;
            this._price = price;
            this._expiryDate = expiryDate;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Name: " + this._name);
            Console.WriteLine("Price: " + this._price);
            Console.WriteLine("Expiry Date: " + this._expiryDate);
        }
    }

    class Beverage : Product
    {
        private double _litres;
        private string _flavor;

        public Beverage(string name, double price, string expiryDate, double litres, string flavor):base(name, price, expiryDate)
        {
            this._litres = litres;
            this._flavor = flavor;
        }

        public void BeverageDetails()
        {
            PrintDetails();

            Console.WriteLine("Litres: " + this._litres);
            Console.WriteLine("Flavor: " + this._flavor);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Beverage cola = new Beverage("RC Cola", 0.7, "8/12/2019", 0.35, "Cola");
            cola.BeverageDetails();
        }
    }
}

using System;

namespace SingleInheritance
{
    /*
         In single inheritance, there is only a single class
         extending from another class. We can take the example
         of the Product class (base class) and the Beverage class
         (derived class).
    */
    class Product
    {
        private string _name;
        private double _price;
        private string _expiryDate;

        public Product(string name, double price, string expiryDate)
        {
            _name = name;
            _price = price;
            _expiryDate = expiryDate;
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

        public Beverage(string name, double price, string expiryDate, double litres, string flavor) : base(name, price, expiryDate)
        {
            this._litres = litres;
            this._flavor = flavor;
        }

        public void BeverageDetails()
        {  //details of Beverage
            PrintDetails();         //calling inherited method from parent class
                                    // Printing fields of this class
            Console.WriteLine("Litres: " + this._litres);
            Console.WriteLine("Flavor: " + this._flavor);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Beverage cola = new Beverage("Fanta", 0.5, "12/12/2019", 0.35, "Grape");
            cola.BeverageDetails();
        }
    }
}

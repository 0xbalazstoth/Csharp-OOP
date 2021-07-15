using System;

namespace MultiLevelInheritance
{
    /*
        When a class is derived from a class that itself is
        derived from another class it is called multi-level
        inheritance. Classes can be extended to any further
        levels as per the requirement of the model. 
    */
    class Product
    {
        // Private Fields: Common attributes of all type of products
        private string _name;
        private double _price;
        private string _expiryDate;

        // Parameterized Constructor
        public Product(string name, double price, string expiryDate)
        {
            this._name = name;
            this._price = price;
            this._expiryDate = expiryDate;
        }

        //getter for name
        public string GetName()
        {
            return this._name;
        }

        // public method to print details
        public void PrintDetails()
        {
            Console.WriteLine("Name: " + this._name);
            Console.WriteLine("Price: " + this._price);
            Console.WriteLine("Expiry Date: " + this._expiryDate);
        }
    }

    class Beverage : Product
    {
        // Private fields : Fields specific to the derived class
        private double _litres;
        private string _flavor;

        // Parameterized Constructor
        public Beverage(string name, double price, string expiryDate, double litres, string flavor)
            : base(name, price, expiryDate) //calling parent class constructor
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

    class Soda : Beverage
    {
        private bool _isCaffeinated;
        private bool _isDiet;

        public Soda(string name, double price, string expiryDate, double litres, string flavor, bool isCaffeinated, bool isDiet)
            : base(name, price, expiryDate, litres, flavor)
        {
            _isCaffeinated = isCaffeinated;
            _isDiet = isDiet;
        }

        public void SodaDetails()
        {
            BeverageDetails();
            Console.WriteLine("Is the {0} caffeinated? {1}", GetName(), this._isCaffeinated);
            Console.WriteLine("Is the {0} diet? {1}", GetName(), this._isDiet);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Soda cola = new Soda("CocaCola", 0.9, "12/12/2019", 0.35, "Cola", false, true);
            cola.SodaDetails();
        }
    }
}

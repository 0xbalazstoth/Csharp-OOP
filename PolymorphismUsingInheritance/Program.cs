using System;

namespace PolymorphismUsingInheritance
{
    class Product
    {

        private string _name;
        private double _purchasePrice;

        // Parameterized Constructor
        public Product(string name, double purchasePrice)
        {
            this._name = name;
            this._purchasePrice = purchasePrice;
        }

        // Getter to access the purchase price of products
        public double GetPurchasePrice()
        {
            return this._purchasePrice;
        }

        public string GetName()
        {
            return this._name;
        }

        // Method GetPrice() to be re-implemented in the derived classes
        public virtual double GetPrice()
        {
            return 0;
        }

        // Method to print name and to be re-implemented in the derived classes for selling price
        public virtual void PrintDetails()
        {
            Console.WriteLine("Selected Product's Name: " + this._name);
        }
    }

    class Beverage : Product
    {
        private double _refCost;
        private double _profit;

        public Beverage(string name, double price) :base(name, price)
        {
            this._refCost = GetPurchasePrice() * 0.10;
            this._profit = GetPurchasePrice() * 0.15;
        }

        public override double GetPrice()
        {
            return (GetPurchasePrice() + (int)Math.Round(this._refCost) + (int)Math.Round(this._profit));
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Selling price: {0}", this.GetPrice());
        }
    }

    class Chocolate : Product
    {
        private double _profit;

        public Chocolate(string name, double price) : base(name, price)
        {
            this._profit = base.GetPurchasePrice() * 0.20;
        }

        public override double GetPrice()
        {
            return (base.GetPurchasePrice() + (int)Math.Round(this._profit));
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Selling price: {0}", this.GetPrice());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[4];
            products[0] = new Beverage("Cola", 9);
            products[1] = new Chocolate("Crunch", 15);
            products[2] = new Chocolate("Kit-Kat", 20);
            products[3] = new Beverage("Fanta", 8);

            foreach (Product product in products)
            {
                product.PrintDetails();
            }
        }
    }
}

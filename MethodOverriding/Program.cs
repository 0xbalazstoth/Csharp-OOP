using System;

namespace MethodOverriding
{
    class Product
    {
        private string _name;
        private double _purchasePrice;

        public Product(string name, double purchasePrice)
        {
            _name = name;
            _purchasePrice = purchasePrice;
        }

        public string GetName()
        {
            return this._name;
        }

        public double GetPurchasePrice()
        {
            return this._purchasePrice;
        }

        public virtual double GetPrice()
        {
            return 0;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine("Selected Product's Name: " + this.GetName());
        }
    }

    class Beverage : Product
    {
        private double _refCost;
        private double _profit;

        public Beverage(string name, double price) : base(name, price)
        {
            _refCost = GetPurchasePrice() * 0.10;
            _profit = GetPurchasePrice() * 0.15;
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
            _profit = base.GetPurchasePrice() * 0.20;
        }

        public override double GetPrice()
        {   //calculating selling price, Math.ceiling is just an ibuilt method to round off the price
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
            products[2] = new Chocolate("Kit-kat", 20);
            products[3] = new Beverage("Fanta", 8);

            // name and price of respective  product is displayed
            foreach (Product product in products)
                product.PrintDetails();
        }
    }
}

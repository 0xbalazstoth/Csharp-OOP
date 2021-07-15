using System;

namespace HybridInheritance
{
    interface Product
    {
        string Brand();
        int Price();
    }

    interface RedBull
    {
        bool isHealthy();
    }

    class Beverage : Product, RedBull
    {
        private string _brand;
        private int _price;

        public Beverage(string brand, int price)
        {
            _brand = brand;
            _price = price;
        }

        public string Brand()
        {
            return this._brand;
        }

        public bool isHealthy()
        {
            return true;
        }

        public int Price()
        {
            return this._price;
        }
    }

    class EnergyDrink : Product, RedBull
    {
        private string _brand;
        private int _price;

        public EnergyDrink(string brand, int price)
        {
            _brand = brand;
            _price = price;
        }

        public string Brand()
        {
            return this._brand;
        }

        public bool isHealthy()
        {
            return false;
        }

        public int Price()
        {
            return this._price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Beverage("Water", 12);
            Console.WriteLine(product.Brand());
            Console.WriteLine(product.Price());

            RedBull redbull = new EnergyDrink("RedBull", 25);
            Console.WriteLine(redbull.isHealthy());

            EnergyDrink energyDrink = new EnergyDrink("Hell", 14);
            Console.WriteLine(energyDrink.Brand());
            Console.WriteLine(energyDrink.Price());
            Console.WriteLine(energyDrink.isHealthy());

            Beverage bev = new Beverage("Cola", 20);
            Console.WriteLine(bev.Brand());
            Console.WriteLine(bev.Price());
            Console.WriteLine(bev.isHealthy());
        }
    }
}

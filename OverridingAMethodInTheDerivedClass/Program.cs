using System;

namespace OverridingAMethodInTheDerivedClass
{
    class Product
    {
        private string _className;

        public Product()
        {
            this._className = "Product";
        }

        public virtual string GetClassName()
        {
            return this._className;
        }
    }
    class XProduct : Product
    {
        private string _className;

        public XProduct(string className)
        {
            // Parameterized Constructor
            this._className = className;
        }

        //Overide and implement the GetClassName method here

        public override string GetClassName()
        {
            return $"{base.GetClassName()}, {this._className}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product beverage = new XProduct("Beverage");
            Console.WriteLine(beverage.GetClassName());
        }
    }
}

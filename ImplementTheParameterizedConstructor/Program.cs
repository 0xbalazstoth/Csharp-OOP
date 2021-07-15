using System;

namespace ImplementTheParameterizedConstructor
{
    class Laptop
    {
        public string Name;

        public Laptop(string name)
        {
            this.Name = name;
        }
    }

    class Dell : Laptop
    {
        private string _name;

        public new string Name
        {
            get
            {
                return _name;
            }
        }

        // Modify the below Parametrized Constructor
        public Dell(string name) : base(name)
        {
            this._name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dell dell = new Dell("Dell Inspiron");
            Console.WriteLine(dell.Name);
        }
    }
}

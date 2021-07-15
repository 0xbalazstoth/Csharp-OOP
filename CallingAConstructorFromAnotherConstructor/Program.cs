using System;

namespace CallingAConstructorFromAnotherConstructor
{
    class VendingMachines
    {
        private bool _onOff;
        private int _count;
        private int _capacity = 100;
        private int _moneyCollected;

        public VendingMachines()
        {
            // Use of this keyword on the left side of = operator
            this._onOff = false;
            this._count = 0;
            this._moneyCollected = 0;
        }

        public VendingMachines(bool onOff, int count)
        {
            // Use of this keyword on the left side of = operator
            this._onOff = onOff;
            this._count = count;
        }

        public VendingMachines(bool onOff, int count, int moneyCollected) : this(onOff, count)  // Calling the above parameterized constructor
        {
            this._moneyCollected = moneyCollected;
        }

        public void PrintFields()
        {
            Console.WriteLine("Is the machine turned on? {0}", this._onOff);
            Console.WriteLine("The count of products is: {0}", this._count);
            Console.WriteLine("The capacity of machine is: {0}", this._capacity);
            Console.WriteLine("The total money collected till now is: {0}\n", this._moneyCollected);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            /*
                In C#, we can call a constructor from another constructor.
                When you call a constructor from another constructor, you use
                the this keyword followed by () to refer to the constructor.
             */

            // Object created with parameterized constructor!
            VendingMachines vendingMachines1 = new VendingMachines(true, 50, 10);

            // Object created with overloaded constructor! 
            VendingMachines vendingMachines2 = new VendingMachines(true, 5);

            // Object created with parameter-less constructor!
            VendingMachines vendingMachines3 = new VendingMachines();

            vendingMachines1.PrintFields();
            vendingMachines2.PrintFields();
            vendingMachines3.PrintFields();
        }
    }
}

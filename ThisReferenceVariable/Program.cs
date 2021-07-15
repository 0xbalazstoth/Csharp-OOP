using System;

namespace ThisReferenceVariable
{
    class VendingMachine
    {
        #region Accessing a Field
        /*
            We can use the this when we have a method argument
            which has the same name as a field. It’s always a
            good convention for the beginners to use the this
            keyword in their class implementation when initializing
            or accessing the fields. This will help us avoid any
            confusion or errors.
         */

        private int moneyCollected = 70;

        public void PrintMoney(int moneyCollected)
        {
            Console.WriteLine("Money Collected using this variable: " + this.moneyCollected);
            Console.WriteLine("Money Collected without using this variable: " + moneyCollected);
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.PrintMoney(-10);
        }
    }
}

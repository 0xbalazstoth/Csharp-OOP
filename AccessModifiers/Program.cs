using System;

namespace AccessModifiers
{
    class VendingMachine
    {
        private int _count = 30; // private field

        public int GetCount() // public method
        {
            return _count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Types of Access Modifiers
            /*
                - private
                - public
                - protected
                - internal
                - protected internal
                - private protected
             */
            #endregion

            VendingMachine vendingMachine = new VendingMachine();
            // cant access _count field, because its private
            Console.WriteLine(vendingMachine.GetCount());
        }
    }
}

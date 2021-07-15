using System;

namespace StaticNonStaticMethods
{
    class VendingMachine
    {
        #region Static methods
        /*
            Static methods, just like static variables,
            can be called from another class without
            instantiating/creating an object of the class.
            These methods can be called using the class’ name. 

            Static methods cannot access non-static variables
            directly, i.e., without creating an instance of a class.
         */

        static string manufacturer = "Vendy";

        public static void DisplayManufacturer()
        {
            Console.WriteLine(manufacturer);
        }
        #endregion
        #region Non-Static methods
        /*
            Non-static methods of a class can only be called with
            reference to a specific instance of that class.
            Since the non-static methods are referenced using a
            specific object, we can say that they can be used to
            perform an object-specific operation. Non-static methods
            are also referred to as instance methods.
         */

        static string nonStaticManufacturer = "Vendy";

        public void NonStaticDisplayManufacturer()
        {
            Console.WriteLine(nonStaticManufacturer);
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine.DisplayManufacturer();

            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.NonStaticDisplayManufacturer();
        }
    }
}

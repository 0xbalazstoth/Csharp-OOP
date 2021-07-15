using System;

namespace Fields
{
    class VendingMachine
    {
        // Static field
        public static int capacity = 5;

        // Non-Static fields
        public int count;
        public int moneyCollected;

        // Read only field
        public readonly string Manufacturer;

        public VendingMachine(string s)
        {
            Manufacturer = s;
            Console.WriteLine($"Manufacturer: {Manufacturer}");
        }

        // const Field
        public const string Brand = "LLA";
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Types of Fields
            /*
                - Non-Static
                - Static
                - Read only
             */
            #endregion

            VendingMachine obj1 = new VendingMachine("Vendy");
            Console.WriteLine(obj1.count);
            Console.WriteLine(obj1.moneyCollected);
            Console.WriteLine(VendingMachine.capacity);
            // obj1.Manufacturer = "readonly"; Cant change because its readonly
            Console.WriteLine(VendingMachine.Brand);
        }
    }
}

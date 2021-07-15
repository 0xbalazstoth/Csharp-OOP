using System;

namespace GettersSettersAndProperties
{
    class VendingMachine
    {
        #region Getter and Setter methods
        /*
            A get method retrieves the value of a particular field,
            whereas a set method changes its value.

            While writing a getter or a setter method, it is a
            common convention to write the name of the corresponding
            field preceded by the Get or Set words, respectively.
         */

        private int _count;
        private int _capacity = 100;

        public void SetCount(int x)
        {
            if (x >= 0 && x <= _capacity)
            {
                _count = x;
            }
        }

        public int GetCount()
        {
            return _count;
        }
        #endregion
        #region Properties
        /*
            Properties are class members which can be used as an
            alternative to the getter and setter methods.
         */

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value >= 0 && value <= _capacity)
                {
                    _count = value;
                }
            }
        }
        #endregion
        #region Auto-Implemented Properties
        /*
            C# provides us the option of using auto-implemented
            properties. In this case, we don’t even have to declare the
            field separately.
         */
        public int AutoCount { get; set; }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Getter & Setter
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.SetCount(88);
            Console.WriteLine(vendingMachine.GetCount());

            // Properties
            vendingMachine.Count = 88;
            Console.WriteLine(vendingMachine.Count);

            // Auto-Implemented Properties
            Console.WriteLine(vendingMachine.Count = 99);
        }
    }
}

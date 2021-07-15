using System;

namespace Constructors
{
    class DefaultConstructor
    {
        /*
            When there is no constructor implemented in a class,
            a default constructor is always implemented by the compiler
            automatically. When called, it creates an object in which
            the fields are initialized to their default values.
         */

        private bool _onOff;
        private int _count;
        private int _capacity;
        private int _moneyCollected;

        // No constructor implemented

        public void PrintFields()
        {
            Console.WriteLine("Is the machine turned on? {0}", _onOff);
            Console.WriteLine("The count of products is: {0}", _count);
            Console.WriteLine("The capacity of machine is: {0}", _capacity);
            Console.WriteLine("The total money collected till now is: {0}", _moneyCollected);
        }
    }
}

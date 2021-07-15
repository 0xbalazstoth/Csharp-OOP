using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class ParameterizedConstructor
    {
        /*
            In a parameterized constructor, we pass arguments to the
            constructor and use these argument values to set the initial
            values of the object fields.

            We are basically overloading the default constructor to
            accommodate our preferred values for the fields.

            We can also implement logical checks before initializing
            field values in a constructor so that invalid values are not
            inadvertently assigned.
         */

        private bool _onOff;
        private int _count;
        private int _capacity;
        private int _moneyCollected;

        public ParameterizedConstructor()
        {
            _onOff = false;
            _capacity = 100;
            _count = 0;
            _moneyCollected = 0;
        }

        public ParameterizedConstructor(bool onOff, int count, int moneyCollected)
        {
            // A parameterized constructor implemented
            _onOff = onOff;
            _capacity = 100;
            _moneyCollected = moneyCollected;
            if (count >= 0 && count <= 100)
            { //Count should always be lesser than or equal to capacity
                _count = count;
            }
            else Console.WriteLine("Invalid count vlaue!");
        }

        public void PrintFields()
        {

            Console.WriteLine("Is the machine turned on? {0}", _onOff);
            Console.WriteLine("The count of products is: {0}", _count);
            Console.WriteLine("The capacity of machine is: {0}", _capacity);
            Console.WriteLine("The total money collected till now is: {0} \n", _moneyCollected);
        }
    }
}

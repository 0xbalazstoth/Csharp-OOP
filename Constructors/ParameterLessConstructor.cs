using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class ParameterLessConstructor
    {
        /*
            The parameter-less constructor is pretty much similar to the
            default constructor. The difference is that we implement it on
            our own and assign some initial values to the fields. By using
            the parameter-less constructor we can make sure that whenever an
            object of a class is created using this constructor its fields
            should have those initialized values stored in them.
         */

        private bool _onOff;
        private int _count;
        private int _capacity;
        private int _moneyCollected;

        public ParameterLessConstructor()
        {
            _onOff = false;
            _capacity = 100;
            _count = 0;
            _moneyCollected = 0;
        }

        public void PrintFields()
        {
            Console.WriteLine("Is the machine turned on? {0}", _onOff);
            Console.WriteLine("The count of products is: {0}", _count);
            Console.WriteLine("The capacity of machine is: {0}", _capacity);
            Console.WriteLine("The total money collected till now is: {0}", _moneyCollected);
        }
    }
}

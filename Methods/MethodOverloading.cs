using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Calculator
    {
        #region Method overloading
        /*
            Methods that have no arguments and differ only in the
            return types cannot be overloaded since the compiler
            won’t be able to differentiate between their calls.
         */
        #endregion

        #region Advantages of method overloading
        /*
            - Code becomes simple and clean
            - We don’t have to keep track of different method names.
         */
        #endregion

        public double Product(double x, double y)
        {
            return x * y;
        }

        // Overloading the function to handle three arguments
        public double Product(double x, double y, double z)
        {
            return x * y * z;
        }

        // Overloading the function to handle int
        public int Product(int x, int y)
        {
            return x * y;
        }
    }
}

using System;

namespace PrivateProtected
{
    public class BaseClass
    {
        private protected int myValue = 0;
    }

    public class DerivedClass1 : BaseClass
    {
        void Access()
        {
            // accessed through the current derived class instance
            myValue = 5;
        }
    }
}

using System;

namespace ProtectedInternal
{
    public class BaseClass
    {
        protected internal int myValue = 0;
    }

    class TestAccess
    {
        void Access()
        {
            BaseClass baseObj = new BaseClass();
            baseObj.myValue = 5;
        }
    }
}

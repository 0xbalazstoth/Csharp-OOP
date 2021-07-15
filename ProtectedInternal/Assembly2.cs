using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedInternal
{
    class DerivedClass : BaseClass
    {
        static void Main()
        {
            BaseClass baseObject = new BaseClass();
            DerivedClass derivedObject = new DerivedClass();

            // this class derives from BaseClass.
            derivedObject.myValue = 10;
        }
    }
}

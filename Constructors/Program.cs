using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default constructor
            //DefaultConstructor defConstructor = new DefaultConstructor();
            //defConstructor.PrintFields();
            #endregion
            #region Parameter-Less constructor
            //ParameterLessConstructor pmeterLessConstructor = new ParameterLessConstructor();
            //pmeterLessConstructor.PrintFields();
            #endregion
            #region Parameterized constructor
            ParameterizedConstructor parameterizedConstructor = new ParameterizedConstructor(onOff: true, count: 1, moneyCollected: 55);
            parameterizedConstructor.PrintFields();
            #endregion
        }
    }
}

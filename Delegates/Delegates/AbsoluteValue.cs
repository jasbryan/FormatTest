using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class AbsoluteValue
    {

        public double ComputeValue(int someValue)
        {
            if (someValue >= 0) return someValue;
            else return someValue * -1;
        }
    }
}

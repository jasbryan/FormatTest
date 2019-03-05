using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class FactorialNumbers
    {

        public double ComputeValue(int someValue)
        {
            if (someValue == 0) return 0;
            if (someValue < 0) return -1;
            double tempy = 1;
            for(int i=1; i<=someValue; i++)
            {
                tempy *= i;
            }
            return tempy;
        }
    }
}

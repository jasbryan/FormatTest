using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class Computer
    {

        private int _number;
               
        public Computer(int number)
        {
            _number = number;
        }

        public delegate double ComputeAnswer(int theValue);

        public void GetAnswer(ComputeAnswer func)
        {
            Console.WriteLine("Here is the answer: {0}", func(_number));
        }

        
    }
}

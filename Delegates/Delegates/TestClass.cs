using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class TestClass
    {

        static void Main()
        {
            var tempInt = new int();
            Console.Write("Please give me a nice integer:");
            String test = Console.ReadLine();
            try
            {
                tempInt = Convert.ToInt32(test);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Input string is not a sequence of digits. {0}", e);
            }

            var comp1 = new Computer(tempInt);

            var fac1 = new FactorialNumbers();            

            var square1 = new SquareNumbers();

            comp1.GetAnswer(fac1.ComputeValue);
            comp1.GetAnswer(square1.ComputeValue);

        }


    }

}

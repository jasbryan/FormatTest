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

            var absv1 = new AbsoluteValue();

            Console.WriteLine("HEre is the Factorial: ");
            comp1.GetAnswer(fac1.ComputeValue);
            Console.WriteLine("HEre is the square:");
            comp1.GetAnswer(square1.ComputeValue);
            Console.WriteLine("HEre is the Absolute Value: ");
            comp1.GetAnswer(absv1.ComputeValue);


        }


    }

}

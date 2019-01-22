using System;
using System.Collections.Generic;
using System.Text;

namespace FormatTest
{
    class TestInterface
    {
        private static void FormatRecord(IFormatter thing)
        {
            thing.Format();
        }

        private static string GetRecordType()
        {
            Console.WriteLine("1--reate a phone number record");
            Console.WriteLine("2--Create a social security record");
            Console.WriteLine("0--exit");
            return Console.ReadLine();
        }

        static void Main()
        {
            bool keepGoing = true;

        private string userChoice;
    }
    }
    }
}

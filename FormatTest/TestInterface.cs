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

            string userChoice = "";

            while(keepGoing)
            {
                userChoice = TestInterface.GetRecordType();
                IFormatter input;
                switch (userChoice)
                {
                    case "1":
                        Console.Write("Please enter Phone number with just 10 digits:");
                        input = new PhoneNumber(Console.ReadLine());
                        input.Format();
                        Console.WriteLine($"Here is your awesome output: {input}");
                        break;
                    case "2":
                        Console.Write("Please enter Social Security number with just 9 digits:");
                        input = new SocialSecurityNumber(Console.ReadLine());
                        input.Format();
                        Console.WriteLine($"Here is your awesome output: {input}");                        
                        break;
                    case "0":
                        keepGoing = false;
                        break;
                    default:
                        break;
                };

                

            }

        }

    }
}

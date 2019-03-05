using System;

namespace FIFOdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var CR1 = new CustomerRecord("blow", "jow", "324-234-1212");
            var CR2 = new CustomerRecord("blow", "jolene", "123-345-5678");
            var CR3 = new CustomerRecord("blow", "john", "324-234-2121");
            var CR4 = new CustomerRecord("blow", "josephene", "987-789-6789");
            var CR5 = new CustomerRecord("blow", "jason", "324-234-4545");

            var myStack = new StackElement<CustomerRecord> { };

            myStack.Push(CR1);
            myStack.Push(CR2);
            myStack.Push(CR3);
            myStack.Push(CR4);
            myStack.Push(CR5);

            DisplayCusStack(myStack);

            Console.WriteLine("My first Pop: {0}", myStack.Pop().ToString());
            DisplayCusStack(myStack);

            Console.WriteLine("My first Peek: {0}", myStack.Peek().ToString());
            DisplayCusStack(myStack);

            Console.WriteLine("My second Pop: {0}", myStack.Pop().ToString());
            DisplayCusStack(myStack);

            Console.WriteLine("Added a few more objects back in");
            myStack.Push(CR4);
            myStack.Push(CR3);
            DisplayCusStack(myStack);

        }

        private static void DisplayCusStack(StackElement<CustomerRecord> theCustomers)
        {
            Console.WriteLine($"Current Stack::");
            foreach (var cus in theCustomers)
            {
                Console.WriteLine($"Here is the next Customer:{cus}");
            }

        }
    }
}

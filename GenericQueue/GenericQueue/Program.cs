using System;

namespace GenericQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var q = new Queue<string>();

            q.Enqueue("Job1");
            q.Enqueue("Job2");
            q.Enqueue("Job3");

            q.PrintQueue();
            q.Dequeue();
            q.PrintQueue();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GenericQueue
{
    class Queue<T>
    {
        private MyList<T> _mylist = new MyList<T>();

        public void Enqueue(T data)
        {
            _mylist.Add(data);
        }

        public T Dequeue()
        {
            return _mylist.Remove();
        }

        public void PrintQueue()
        {
            var current = _mylist.head;
            while(current != null)
            {
                Console.Write($"{current.Data} -->");
                Console.WriteLine("");
                current = current.Next;
            }
                
        }



    }
}

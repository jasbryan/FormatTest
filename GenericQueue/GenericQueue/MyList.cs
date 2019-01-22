using System;
using System.Collections.Generic;
using System.Text;

namespace GenericQueue
{
    class MyList<T>
    {
        public MyNode<T> head { get; set; }

        public MyNode<T> tail { get; set; }

        public void Add(T data)
        {
            var n = new MyNode<T>
            {
                Data = data,
                Next = null
            };

            if (head == null)
            {
                head = n;
                tail = n;
            }else
            {
                tail.Next = n;
                tail = n;
            }
            
        }

        public T Remove()
        {
            if(head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }

            var n = head;
            head = head.Next;

            if(head == null)
            {
                tail = null;
            }

            return n.Data;
                       
        }



    }
}

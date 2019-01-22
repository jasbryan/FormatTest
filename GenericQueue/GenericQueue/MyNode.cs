using System;
using System.Collections.Generic;
using System.Text;

namespace GenericQueue
{
    class MyNode<Tdata>
    {
        public Tdata Data { get; set; }

        public MyNode<Tdata> Next { get; set; }
    }
}

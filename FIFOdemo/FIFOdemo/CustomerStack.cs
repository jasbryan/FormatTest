using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FIFOdemo
{
    class StackElement<T> : IEnumerable<T>
    {
        private List<T> ourList;

        public StackElement()
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

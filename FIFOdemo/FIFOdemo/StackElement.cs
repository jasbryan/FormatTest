using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FIFOdemo
{
    class StackElement<T> : IEnumerable<T>
    {
        private List<T> _ourList;

        public int Count { get => _ourList.Count; }

        public StackElement()
        {
            _ourList = new List<T> {};
        }

        public void Push(T obj)
        {
            _ourList.Add(obj);
        }

        public T Pop()
        {
            if (_ourList.Count > 0)
            {
                var temp = _ourList[_ourList.Count - 1];
                _ourList.RemoveAt(_ourList.Count - 1);
                return temp;
            } else { throw new IndexOutOfRangeException("The list is empty"); }
        }

        public T Peek()
        {
            if(_ourList.Count > 0)
            {
                return _ourList[0];
            }
            else { throw new IndexOutOfRangeException("The list is empty"); }
        }
  
        public IEnumerator<T> GetEnumerator()
        {
            if (_ourList.Count > 0)
            {
                var temp = new List<T> { };
                for (int i = _ourList.Count - 1; i >= 0; i--)
                {
                    temp.Add(_ourList[i]);
                }
                return temp.GetEnumerator();
            }
            else { throw new IndexOutOfRangeException("The list is empty"); }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

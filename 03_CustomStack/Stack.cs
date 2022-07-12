using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03_CustomStack
{
    public class Stack<T> : IEnumerable<T>
    {

        private List<T> list;

        public Stack(params T[] data)
        {
            list = new List<T>();
        }

        public void Push(params T[] elements)
        {
            foreach(T element in elements)
            {
                list.Insert(list.Count, element);
            }
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

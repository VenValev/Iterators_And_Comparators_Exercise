﻿using System;
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
            list = new List<T>(data); //!!! Vse zabravq6 datata!!!

        }

        public void Push(params T[] elements)
        {
            foreach(var element in elements)
            {
                list.Insert(list.Count, element);
            }
        }

        public T Pop()
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("No elements");
            }

            T element = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return element;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for(int i = list.Count - 1; i >= 0; i--)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}

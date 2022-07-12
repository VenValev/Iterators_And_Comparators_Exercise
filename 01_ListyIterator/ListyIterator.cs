using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _01_ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;
        private int currIndex;
        public ListyIterator(params T[] data)
        {
            list = new List<T>(data);
            currIndex = 0;
        }

        

        public bool HasNext() => currIndex < list.Count - 1;

        public bool Move()
        {
            bool canMove = HasNext();

            if (canMove)
            {
                currIndex++;
            }

            return canMove;
        }
        public void Print()
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            Console.WriteLine($"{list[currIndex]}");
        }

        public void PrintAll()
        {
            Console.WriteLine(String.Join(" ", list));
        }

        IEnumerator IEnumerable.GetEnumerator() // => throw new NotImplementedException();
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list)
            {
                yield return item;
            }
        }
    }
}

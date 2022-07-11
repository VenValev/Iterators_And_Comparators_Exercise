using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> list;
        private int currIndex;
        public ListyIterator(params T[] data)
        {
            list = new List<T>();
        }
    }
}

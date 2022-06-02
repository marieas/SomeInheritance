using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class MariesSpesialListeForOCD<T> : List<T>
    {
        public void AddThree(T item1, T item2, T item3)
        {
            Add(item1);
            Add(item2);
            Add(item3);
        }
    }
}

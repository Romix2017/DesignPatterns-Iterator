using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorRealWorld
{
    public class Collection : IAbstractCollection
    {
        private ArrayList items = new ArrayList();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        public int Count
        {
            get { return items.Count; }
        }
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Add(value); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorRealWorld
{
    public class Item
    {
        private string name;
        public Item(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
    }
}

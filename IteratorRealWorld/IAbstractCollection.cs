using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorRealWorld
{
    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}

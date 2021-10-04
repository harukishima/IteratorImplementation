using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorImplementation
{
    interface ListNodeP<T>
    {
        public abstract Iterator<T> GetForwardIterator();
        public abstract Iterator<T> GetBackwardIterator();
    }
}

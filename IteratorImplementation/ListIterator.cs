using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorImplementation
{
    abstract class ListIterator<T> : Iterator<T>
    {
        protected LinkedListNodeP<T> CurrentNode;
        protected LinkedListNodeP<T> List;
        public abstract void First();

        public abstract T GetCurrent();

        public abstract bool HasNext();

        public abstract T Next();
    }
}

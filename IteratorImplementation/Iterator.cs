using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorImplementation
{
    interface Iterator<T>
    {
        public abstract void First();
        public abstract T Next();
        public abstract bool HasNext();
        public abstract T GetCurrent();
    }
}

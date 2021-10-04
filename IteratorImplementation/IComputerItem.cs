using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorImplementation
{
    interface IComputerItem
    {
        public abstract void Add(IComputerItem item);
        public abstract IComputerItem GetChild(int index);
        public abstract Iterator<IComputerItem> GetIterator();
    }
}

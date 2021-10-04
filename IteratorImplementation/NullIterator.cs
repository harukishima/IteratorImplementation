using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorImplementation
{
    class NullIterator : Iterator<IComputerItem>
    {
        public void First()
        {
            throw new NotImplementedException();
        }

        public IComputerItem GetCurrent()
        {
            throw new NotImplementedException();
        }

        public bool HasNext()
        {
            return false;
        }

        public IComputerItem Next()
        {
            return null;
        }
    }
}

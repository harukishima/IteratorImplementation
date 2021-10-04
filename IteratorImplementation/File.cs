using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorImplementation
{
    class File : IComputerItem
    {
        public String Name { get; set; }
        public String Extension { get; set; }
        public String Size { get; set; }

        public void Add(IComputerItem item)
        {
            throw new NotSupportedException();
        }

        public IComputerItem GetChild(int index)
        {
            return null;
        }

        public Iterator<IComputerItem> GetIterator()
        {
            return new NullIterator();
        }
        public override string ToString()
        {
            return $"File: {Name}.{Extension}";
        }
    }
}

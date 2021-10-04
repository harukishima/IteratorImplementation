using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorImplementation
{
    class CListIterator<T> : Iterator<T>
    {
        private List<T> List;
        private int count;
        public CListIterator(List<T> list)
        {
            this.List = list;
            count = 0;
        }
        public void First()
        {
            count = 0;
        }

        public T GetCurrent()
        {
            return List[count];
        }

        public bool HasNext()
        {
            return count < List.Count;
        }

        public T Next()
        {
            if (HasNext())
            {
                T tmp = List[count];
                count++;
                return tmp;
            }
            return default;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorImplementation
{
    class FolderIterator : Iterator<IComputerItem>
    {
        private Stack<Iterator<IComputerItem>> stack = new(); 
        public FolderIterator(Iterator<IComputerItem> iterator)
        {
            stack.Push(iterator);
        }
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
            if (stack.Count == 0)
                return false;
            else
            {
                Iterator<IComputerItem> iterator = stack.Peek();
                if (!iterator.HasNext())
                {
                    stack.Pop();
                    return HasNext();
                } else
                {
                    return true;
                }
            }
        }

        public IComputerItem Next()
        {
            if (HasNext())
            {
                Iterator<IComputerItem> iterator = stack.Peek();
                IComputerItem item = iterator.Next();

                if (item is Folder)
                {
                    stack.Push(item.GetIterator());
                }
                return item;
            } else
            {
                return null;
            }
        }
    }
}

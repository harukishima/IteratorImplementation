using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorImplementation
{
    class BackwardListIterator<T> : ListIterator<T>
    {
        public BackwardListIterator(LinkedListNodeP<T> list)
        {
            List = list;
            CurrentNode = list;
        }
        public override void First()
        {
            CurrentNode = List;
            while (CurrentNode.NextNode != null)
                CurrentNode = CurrentNode.NextNode;
        }

        public override T GetCurrent()
        {
            return this.CurrentNode.Key;
        }

        public override bool HasNext()
        {
            return CurrentNode != null;
        }

        public override T Next()
        {
            if (CurrentNode != null)
            {
                LinkedListNodeP<T> tmp = CurrentNode;
                CurrentNode = CurrentNode.PreviousNode;
                return tmp.Key;
            }
            return default;
        }
    }
}

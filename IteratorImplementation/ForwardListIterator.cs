using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorImplementation
{
    class ForwardListIterator<T> : ListIterator<T>
    {
        public ForwardListIterator(LinkedListNodeP<T> list)
        {
            List = list;
            this.CurrentNode = list;
        }
        public override void First()
        {
            CurrentNode = List;
            while (CurrentNode.PreviousNode != null)
                CurrentNode = CurrentNode.PreviousNode;
        }

        public override T GetCurrent()
        {
            return CurrentNode.Key;
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
                CurrentNode = CurrentNode.NextNode;
                return tmp.Key;
            }
            return default;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorImplementation
{
    class LinkedListNodeP<T> : ListNodeP<T>
    {
        public T Key { get; set; }
        public LinkedListNodeP<T> NextNode { get; set; }
        public LinkedListNodeP<T> PreviousNode { get; set; }
        public LinkedListNodeP(T key)
        {
            NextNode = null;
            PreviousNode = null;
            Key = key;
        }
        public void Push(T key)
        {
            if (NextNode != null)
                NextNode.Push(key);
            else
            {
                NextNode = new LinkedListNodeP<T>(key);
                NextNode.PreviousNode = this;
            }
        }
        public Iterator<T> GetForwardIterator()
        {
            return new ForwardListIterator<T>(this);
        }
        public Iterator<T> GetBackwardIterator()
        {
            return new BackwardListIterator<T>(this);
        }
    }
}

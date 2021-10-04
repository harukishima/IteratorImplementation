using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorImplementation
{
    class Folder : IComputerItem
    {
        public String Name { get; set; }
        
        private List<IComputerItem> items = new List<IComputerItem>();
        public Folder(String name)
        {
            Name = name;
        }
        public void Add(IComputerItem item)
        {
            items.Add(item);
        }
        public void Remove(IComputerItem item)
        {
            items.Remove(item);
        }
        public IComputerItem GetChild(int index)
        {
            return items[index];
        }

        public Iterator<IComputerItem> GetIterator()
        {
            return new FolderIterator(new CListIterator<IComputerItem>(items));
        }
        public override string ToString()
        {
            return $"Folder: {Name}";
        }
    }
}

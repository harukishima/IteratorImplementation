using System;

namespace IteratorImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedListNodeP<int> startNode = new LinkedListNodeP<int>(0);
            //startNode.Push(1);
            //startNode.Push(2);
            //startNode.Push(3);
            //startNode.Push(4);
            //startNode.Push(5);
            //Iterator<int> iterator = startNode.GetForwardIterator();
            //for(iterator = startNode.GetForwardIterator(); iterator.HasNext(); )
            //{
            //    Console.WriteLine(iterator.Next());
            //}
            //Iterator<int> backward = startNode.GetBackwardIterator();
            //for (backward.First(); backward.HasNext();)
            //{
            //    Console.WriteLine(backward.Next());
            //}
            IComputerItem homeWork = new Folder("Home work");
            IComputerItem entertainment = new Folder("Entertainment");
            IComputerItem movies = new Folder("Movie");
            IComputerItem games = new Folder("Games");
            IComputerItem rootFolder = new Folder("Root");

            entertainment.Add(movies);
            entertainment.Add(games);

            rootFolder.Add(homeWork);
            rootFolder.Add(entertainment);

            games.Add(new File()
            {
                Name = "Pinball",
                Extension = "exe"
            });

            homeWork.Add(new File()
            {
                Name = "report",
                Extension = "docx"
            });
            Iterator<IComputerItem> itemIterator = rootFolder.GetIterator();
            while (itemIterator.HasNext())
            {
                IComputerItem item = itemIterator.Next();
                Console.WriteLine(item.ToString());
            }
        }
    }
}

using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new DoublyLinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(0);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            Console.WriteLine($"Removed: " + list.RemoveFirst());
            Console.WriteLine(list.Count);
            Console.WriteLine($"Removed: " + list.RemoveLast());
            Console.WriteLine(list.Count);



            list.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(list.Count);
            Console.WriteLine(string.Join(", ",list.ToArray()));
        }
    }
}

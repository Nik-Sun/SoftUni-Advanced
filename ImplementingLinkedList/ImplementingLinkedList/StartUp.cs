using System;
using System.Collections.Generic;

namespace CustomDoublyLinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CustomLinkedList list = new CustomLinkedList();
            list.AddLast(3);
            list.RemoveFirst();
            list.AddFirst(3);
            list.RemoveLast();
           
            Console.WriteLine(string.Join("-", list.ToArray()));
            list.AddFirst(2);
            Console.WriteLine(string.Join("-", list.ToArray()));
            list.AddFirst(1);
            Console.WriteLine(string.Join("-", list.ToArray()));
            list.AddFirst(0);
            Console.WriteLine(string.Join("-", list.ToArray()));
            list.RemoveFirst();
            Console.WriteLine(string.Join("-", list.ToArray()));
            list.RemoveLast();
            Console.WriteLine(string.Join("-", list.ToArray()));
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    

    public class DoublyLinkedList<T>
    {
        private class ListNode
        {

            public ListNode Previous { get; set; }
            public ListNode Next { get; set; }
            public T Value { get; set; }
            public ListNode(T value)
            {
                Value = value;
            }
        }

        private ListNode first;
        private ListNode last;
        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            if (first == null)
            {
                first = new ListNode(item);
                last = first;

            }
            else if (first == last)
            {

                first = new ListNode(item);
                first.Next = last;
                last.Previous = first;
            }
            else
            {
                first.Previous = new ListNode(item);
                first.Previous.Next = first;
                first = first.Previous;
            }
            Count++;
        }
        public T RemoveFirst()
        {
            T item = default;
            if (first == null)
            {
                throw new InvalidOperationException("The list is empty");
            }
            else if (first == last)
            {
                item = first.Value;
                first = null;
                last = null;
            }
            else
            {
                item = first.Value;
                first = first.Next;
            }
            Count--;
            return item;
        }
        public void AddLast(T element)
        {
            if (last == null)
            {
                last = new ListNode(element);
                first = last;
            }
            else if (first == last)
            {
                first.Next = new ListNode(element);
                last = first.Next;
                last.Previous = first;
            }
            else
            {
                last.Next = new ListNode(element);
                last.Next.Previous = last;
                last = last.Next;
            }
            Count++;
        }
        public T RemoveLast()
        {
            T item = default;
            if (last == null)
            {
                throw new InvalidOperationException("The list is empty");
            }
            else if (last == first)
            {
                item = last.Value;
                last = null;
                first = null;
            }
            else
            {
                item = last.Value;
                last = last.Previous;
                last.Next = null;
            }
            Count--;
            return item;
        }
        public void ForEach(Action<T> action)
        {
            ListNode current = first;
            while (current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }
        public T[] ToArray()
        {
            List<T> temp = new List<T>();
            ListNode current = first;
            while (current != null)
            {
                temp.Add(current.Value);
                current = current.Next;
            }
            return temp.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    class CustomLinkedList
    {
        private CustomLinkedListItem first;
        private CustomLinkedListItem last;

        public void AddFirst(int num)
        {
            if (first == null)
            {
                first = new CustomLinkedListItem(num);
                last = first;
            }
            else if (first == last)
            {

                first = new CustomLinkedListItem(num);
                first.Next = last;
                last.Previous = first;
            }
            else
            {
                first.Previous = new CustomLinkedListItem(num);
                first.Previous.Next = first;
                first = first.Previous;
            }
        }
        public int RemoveFirst()
        {
            int num = 0;
            if (first == null)
            {
                throw  new InvalidOperationException("The list is empty");
            }
            else if (first == last)
            {
                num = first.Value;
                first = null;
                last = null;
            }
            else
            {
                 num = first.Value;
                first = first.Next;
            }
            return num;
        }
        public void AddLast(int element)
        {
            if (last == null)
            {
                last = new CustomLinkedListItem(element);
                first = last;
            }
            else if (first == last)
            {
                first.Next = new CustomLinkedListItem(element);
                last = first.Next;
                last.Previous = first;
            }
            else
            {
                last.Next = new CustomLinkedListItem(element);
                last.Next.Previous = last;
                last = last.Next;
            }
        }
        public int RemoveLast()
        {
            int num = 0;
            if (last == null)
            {
                throw new InvalidOperationException("The list is empty");
            }
            else if (last == first)
            {
                num = last.Value;
                last = null;
                first = null;
            }
            else
            {
                num = last.Value;
                last = last.Previous;
                last.Next = null;
            }
            return num;
        }
        public void ForEach(Action<int> action)
        {
            var current = first;
            while (current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }
        public int[] ToArray()
        {
            List<int> temp = new List<int>();
            var current = first;
            while (current != null)
            {
                temp.Add(current.Value);
                current = current.Next;
            }
            return temp.ToArray();
        }
    }
}

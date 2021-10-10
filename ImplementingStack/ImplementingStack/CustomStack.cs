using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingStack
{
    class CustomStack<T>
    {
        private StackItem<T> first;
        private int count;


        public int Count { get { return count; } }


        public void Push(T value)
        {
            if (first == null)
            {
                first = new StackItem<T>(value);
                count++;
            }
            else
            {
                var newElement = new StackItem<T>(value);
                newElement.Previous = first;
                first = newElement;
                count++;
            }
        }
        public T Pop()
        {
            T n = first.Value;
            first = first.Previous;
            return n;
        }
        public T Peek()
        {
            return first.Value;
        }
        public void Clear()
        {
            first = null;
        }
        public void ForEach(Action<T> action)
        {
            StackItem<T> current = first;
            while (current != null)
            {
                action(current.Value);
                current = current.Previous;
            }
        }
    }


}

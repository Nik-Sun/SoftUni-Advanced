using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class CustomStack<T> :IEnumerable<T>
    {
        private List<T> elements;

        public CustomStack()
        {
            elements = new List<T>();
        }


        public void Push(params T[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                elements.Add(values[i]);
            }
        }
        public T Pop()
        {
            
            T element = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return element;
        }

       
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = elements.Count - 1; i >= 0; i--)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

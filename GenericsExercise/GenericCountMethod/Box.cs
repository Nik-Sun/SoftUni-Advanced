using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethod

{
    public class Box<T>
        where T: IComparable
    {
        private T content;
        public T Value  { get => content; }  
        public Box(T element)
        {
            content = element;
        }
        public override string ToString()
        {
            return $"{content.GetType()}: {content}";
        }
    }
}

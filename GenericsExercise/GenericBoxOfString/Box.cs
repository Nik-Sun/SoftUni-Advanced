using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
   
{
    public class Box<T>
        where T: IComparable
    {
        private T content;
        public Box(T element)
        {
            content = element;
        }
        public override string ToString()
        {
            return $"{this.content.GetType()}: {content}";
        }
       
    }
}

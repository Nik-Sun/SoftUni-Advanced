using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingStack
{
    class StackItem<T>
    {
        
        public StackItem<T> Previous { get; set; }
       
        public T Value { get; set; }
      
        public StackItem(T element)
        {
            Value = element; 
        }
    }
}

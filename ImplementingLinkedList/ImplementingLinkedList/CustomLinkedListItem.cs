using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    class CustomLinkedListItem
    {
       
        public CustomLinkedListItem Previous { get; set; }
        public CustomLinkedListItem Next { get; set; }
        public int Value { get; set; }
        public CustomLinkedListItem(int value)
        {
            Value = value;
        }
    }
}

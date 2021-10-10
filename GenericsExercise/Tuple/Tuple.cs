using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    class TupleItem<T1,T2>
    {
        private T1 item1;
        private T2 item2;
        public TupleItem()
        {
            item1 = default;
            item2 = default;
        }
        public TupleItem(T1 item1, T2 item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }
        public T1 Item1 { get=>item1; set {  item1 = value; } }
        public T2 Item2 { get=>item2; set {  item2 = value; } }

        public override string ToString()
        {
            return $"{item1} -> {item2}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Threeuple<T1,T2,T3>
    {

        public T1 FirstItem { get; set; }
        public T2 SecondItem { get; set; }
        public T3 ThirdItem { get; set; }
        public Threeuple()
        {
           
        }
        public Threeuple(T1 firstItem,T2 secondItem,T3 thirdItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
            ThirdItem = thirdItem;
        }
        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EqualityLogic
{
    class PersonEqualityComparer : EqualityComparer<Person>
    {
      

        public override bool Equals([AllowNull] Person x, [AllowNull] Person y)
        {
            if (x.Name.ToUpper().CompareTo( y.Name.ToUpper())==0 && x.Age == y.Age)
            {
                return true;
            }
            return false;
        }

        

        public override int GetHashCode([DisallowNull] Person obj)
        {
            return HashCode.Combine(obj.Name.ToUpper(), obj.Age);
        }
    }
}

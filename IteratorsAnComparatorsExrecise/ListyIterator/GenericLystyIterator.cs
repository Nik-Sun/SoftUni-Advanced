using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class GenericLystyIterator<T> : IEnumerable<T>
    {
        private  IReadOnlyList<T> internalList;
        private int index = 0;
        public GenericLystyIterator(params T[] collection)
        {
            internalList = new List<T>(collection);
        }
        public bool Move()
        {
            if (index + 1 < internalList.Count)
            {
                index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            if (index +1<internalList.Count)
            {
                return true;
            }
            return false;
        }
        public void Print()
        {
            try
            {
                Console.WriteLine(internalList[index]);
            }
            catch (SystemException)
            {

                Console.WriteLine("Invalid Operation!");
            }
        }
        public void PrintAll()
        {
            foreach (var item in internalList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(); 
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < internalList.Count; i++)
            {
                yield return internalList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

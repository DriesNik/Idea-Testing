using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingStuff
{
    class CustomList<T> : IEnumerable
    {
        T[] customList;

        public CustomList()
        {
            customList = new T[0];
        }
        public void AddToList(T argumentValue)
        {
            T[] tempList;
            tempList = new T[customList.Length + 1];
            for (int i = 0; i < customList.Length; i++)
            {
                tempList[i] = customList[i];
            }
            tempList[tempList.Length - 1] = argumentValue;
            customList = tempList;
        }
        public void PrintList()
        {
            foreach (T item in customList)
            {
                Console.WriteLine(item);
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < customList.Length; i++)
            {
                yield return customList[i];
            }

        }
    }
}


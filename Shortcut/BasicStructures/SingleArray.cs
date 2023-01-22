using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructures
{
    public class SingleArray<T> : IArray<T>
    {
        T[] array;
        public SingleArray()
        {
            array = new T[0];
        }
        public int Size { get { return array.Length; } }
        public T[] Array
        {
            get { return array; }
        }
        public void Add(T item, int index)
        {
            int length = index + 1;
            T[] tempArray = new T[length];
            tempArray[index] = item;

            for (long i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
        }
        public T Get(int idx)
        {
            return array[idx];
        }
        public T Remove(int index)
        {
            T[] tempArray = new T[array.Length - 1];

            long count = 0;
            while (count < index - 1)
            {
                count++;
                tempArray[count] = array[count];
            }
            count++;
            while (count++ < tempArray.Length)
            {
                tempArray[count - 1] = array[count];
            }

            T outVal = array[index];
            array = tempArray;
            return outVal;
        }
    }
}

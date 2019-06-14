using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortClasses
{
    abstract class InsertionSort<T> : SortType<T>
    {
        public abstract override T GetHigher(T objA, T objB);

        public override void Sort(T[] arr)
        {
            for(int edge = 1; edge<arr.Length; edge++) 
            {
                for (int i = edge; i > 0; i--) //From the current edge backwads
                {
                    if (GetHigher(arr[i], arr[i - 1]).Equals(arr[i - 1])) //if arr[i] < arr[i-1]
                    {
                        Swap(arr, i, i - 1);
                    }
                }
            }
        }

    }

    class IntSizeInsertion : InsertionSort<int>
    {
        public override int GetHigher(int objA, int objB)
        {
            return objA > objB ? objA : objB;
        }
    }

}

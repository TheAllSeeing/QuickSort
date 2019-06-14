using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortClasses
{
    abstract class BubbleSort<T> : SortType<T>
    {
        public override abstract T GetHigher(T objA, T objB);

        /*
         * Sorts the array using the bubble sort algorithm:
         * Checks for every pair of adjuacent vcalues, and if they are not ordered coreectly, swaps them. 
         * Does this until an iteration where no swaps occure: the array is completely ordered.
         */
        public override void Sort(T[] arr)
        {
            bool SwappedInIteration; //wether or not there were swaps in the current iteration.
            for (int i = 0; i < arr.Length; i++) //
            {
                SwappedInIteration = false;

                for (int j = 1; j < arr.Length; j++)
                {
                    T higher = GetHigher(arr[j-1], arr[j]);
                    if(higher.Equals(arr[j-1])) //if arr[i] > arr[i+1]
                    {
                        Swap(arr, j-1, j);
                        SwappedInIteration = true;
                    }
                }

                if (!SwappedInIteration) //If the all elements were sorted, end the loop.
                {
                    break;
                }
            }
        }
    }

    class IntSizeBubble : BubbleSort<int>
    {
        public override int GetHigher(int num1, int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }

            else
            {
                return num2;
            }
        }

    }
}

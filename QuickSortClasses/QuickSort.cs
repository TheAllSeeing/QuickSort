using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortClasses
{
    abstract class QuickSort<T> : SortType<T>
    {
        /// <summary>
        /// Takes two input T objects and returns the one that should be listed later.
        /// </summary>
        /// <param name="pivot"></param>
        /// <param name="objB"></param>
        /// <returns></returns>
        public abstract T GetHigher(T pivot, T objB);
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        protected int Partition(T[] arr, int left, int right)
        {
            int pivotIndex = new Random().Next(left, right); //generate a random pivot
            T pivot = arr[pivotIndex]; //get its object
            Swap(arr, right, pivotIndex); //put the pivot in the right edge of the array
            pivotIndex = left; //Put the pivot"s index at most left, as if it"s the smallest
            for (int i = left; i < right; i++) //For each element of this section of the array
            {
                if (GetHigher(pivot, arr[i]).Equals(pivot)) //If it"s bigger than the pivot
                {
                    Swap(arr, pivotIndex, i); //Swap it with the element at pivot index
                    pivotIndex++; //and raise the pivot index, Such that the element it is now behind the pivot index
                }
            }

            Swap(arr, pivotIndex, right); //Swap the pivot back to its rightful place
            return pivotIndex;

        }

        public void Sort(T[] arr, int left, int right)
        {
            if(left >= right)
            {
                return;
            }

            int pivot = Partition(arr, left, right);

            Sort(arr, pivot + 1, right);
            Sort(arr, left, pivot - 1);

        }

        public void Sort(T[] arr)
        {
            Sort(arr, 0, arr.Length-1);
        }

        private void Swap(T[] arr, int indexA, int indexB)
        {
            T temp = arr[indexB];
            arr[indexB] = arr[indexA];
            arr[indexA] = temp;
        }
    }

    class IntSizeSort : QuickSort<int>
    {
        public override int GetHigher(int pivot, int element)
        {
            return pivot >= element ? pivot : element;
        }
    }

    class AlphabetSort : QuickSort<String>
    {
        public int convert(char c)
        {
            switch(c)
            {
                case 'a':
                    return 1;
                case 'b':
                    return 2;
                case 'c':
                    return 3;
                case 'd':
                    return 4;
                case 'e':
                    return 5;
                case 'f':
                    return 6;
                case 'g':
                    return 7;
                case 'h':
                    return 8;
                case 'i':
                    return 9;
                case 'j':
                    return 10;
                case 'k':
                    return 11;
                case 'l':
                    return 12;
                case 'm':
                    return 13;
                case 'n':
                    return 14;
                case 'o':
                    return 15;
                case 'p':
                    return 16;
                case 'q':
                    return 17;
                case 'r':
                    return 18;
                case 's':
                    return 19;
                case 't':
                    return 20;
                case 'u':
                    return 21;
                case 'v':
                    return 22;
                case 'w':
                    return 23;
                case 'x':
                    return 24;
                case 'y':
                    return 25;
                case 'z':
                    return 26;
                default:
                    try
                    {
                        return int.Parse(c.ToString()) + 26;
                    }

                    catch(Exception)
                    {
                        return -1;
                    }
            }
        }

        public override string GetHigher(string pivot, string element)
        {
            string shorter;
            string longer;
            if (pivot.Length <= element.Length)
            {
                shorter = pivot;
                longer = element;
            }

            else
            {
                shorter = element;
                longer = pivot;
            }

            try
            {
                for (int i = 0; i < longer.Length; i++)
                {
                    if (convert(element[i]) == -1)
                    {
                        return pivot;
                    }

                    if (convert(pivot[i]) == -1)
                    {
                        return element;
                    }

                    if (convert(pivot[i]) > convert(element[i]))
                    {
                        return pivot;
                    }

                    if (convert(element[i]) > convert(pivot[i]))
                    {
                        return element;
                    }
                }

            }

            catch(IndexOutOfRangeException)
            {
                return shorter;
            }

            return pivot;

        }
    }
}

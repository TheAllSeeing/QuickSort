using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortClasses
{
    /// <summary>
    /// This class is the base for all the sorting algorithms, containing
    /// the swap method for swapping array values, and the abstract GetHigher and Sort,
    /// which compose the sorting algoriithms
    /// </summary>
    /// <typeparam name="T">The class of the to-be-sorted array's value. </typeparam>
    public abstract class SortType<T>
    {
        /// <summary>
        /// Takes two T parameters and returns the one that should be on the higher position of
        /// the array.
        /// Note that making this an abstract method allows for easy implementnation of different
        /// sorts: it could be sheer number size, allphabetical, and so on.
        /// </summary>
        public  abstract T GetHigher(T objA, T objB);
        
        /// <summary>
        /// The sorting algorithm, which sorts the array by the GetHigher method.
        /// </summary>
        /// <param name="arr"></param>
        public abstract void Sort(T[] arr);

        /// <summary>
        /// Swaps between two valuies of an array
        /// </summary>
        /// <param name="arr">The array to swap the values in.</param>
        /// <param name="indexA">The position of the first value to be swapped.</param>
        /// <param name="indexB">The position of the first value to be swapped</param>
        public void Swap(T[] arr, int indexA, int indexB)
        {
            T temp = arr[indexB];
            arr[indexB] = arr[indexA];
            arr[indexA] = temp;
        }



    }
}
    
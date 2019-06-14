using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace QuickSortClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            IntSizeInsertion InsertionSorter = new IntSizeInsertion();
            WriteLine("Insertion Sort:");
            int[] arr = GenerateRandomArr(10);
            Write("Unsorted Array: ");
            PrntArr(arr);
            WriteLine();
            InsertionSorter.Sort(arr);
            Write("Sorted Array: ");
            PrntArr(arr);

            WriteLine();
            WriteLine();

            IntSizeBubble BubbleSorter = new IntSizeBubble();
            WriteLine("Insertion Sort:");
            arr = GenerateRandomArr(10);
            Write("Unsorted Array: ");
            PrntArr(arr);
            WriteLine();
            BubbleSorter.Sort(arr);
            Write("Sorted Array: ");
            PrntArr(arr);

            WriteLine();
            WriteLine();

            IntSizeQuickSort QuickSorter = new IntSizeQuickSort();
            WriteLine("Insertion Sort:");
            arr = GenerateRandomArr(10);
            Write("Unsorted Array: ");
            PrntArr(arr);
            WriteLine();
            InsertionSorter.Sort(arr);
            Write("Sorted Array: ");
            PrntArr(arr);
            ReadKey();
        }

        static int[] GenerateRandomArr(int size)
        {
            Random rnd = new Random();
            int[] arr = new int[size];

            for(int i = 0; i<size; i++)
            {
                arr[i] = rnd.Next(100);
            }

            return arr;
        }

        static void PrntArr(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}

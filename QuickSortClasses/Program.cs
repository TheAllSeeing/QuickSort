using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            IntSizeSort Sorter = new IntSizeSort();
            int[] arr = GenerateRandomArr(10);
            PrntArr(arr);
            Console.WriteLine();
            Sorter.Sort(arr);
            PrntArr(arr);
            Console.ReadKey();
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

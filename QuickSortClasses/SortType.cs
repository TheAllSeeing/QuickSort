using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortClasses
{
    public interface SortType<T>
    {
       T GetHigher(T objA, T objB);
        void Sort(T[] arr);
    }
}

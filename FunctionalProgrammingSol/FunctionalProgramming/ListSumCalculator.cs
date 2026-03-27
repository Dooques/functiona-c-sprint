using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class ListSumCalculator<T>
    {
        List<T> Items;

        public ListSumCalculator(List<T> list)
        {
            Items = list;
        }

        public long SumBy(Func<T, long> func)
        {
            long result = 0;

            foreach (T item in Items)
            {
                result += func(item);
            }

            return result;
        }
    }
}

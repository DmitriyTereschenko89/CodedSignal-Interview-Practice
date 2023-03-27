using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedSignal_Interview_Practice.Arrays
{
    internal class FirstDuplicate
    {
        public int DuplicateFirst(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                int index = Math.Abs(a[i]) - 1;
                if (a[index] < 0)
                {
                    return Math.Abs(a[i]);
                }
                a[index] *= -1;
            }
            return -1;
        }
    }
}

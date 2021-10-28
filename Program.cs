using System;
using System.Collections.Generic;

namespace Mutates_into_new_array
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 5;
            var a = new int[] { 4, 0, 1, -2, 3 };
            mutateTheArray(n, a);
        }

       static int[] mutateTheArray(int n, int[] a)
        {
            int[] b = new int[n];
            if (a.Length == 1)
            {
                return a;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0 || i == a.Length - 1)
                {
                    if (i == 0)
                    {
                        b[i] = 0 + a[i] + a[i + 1];
                    }
                    else
                    {
                        b[i] = a[i - 1] + a[i] + 0;
                        return b;
                    }
                }
                else
                {
                    b[i] = a[i - 1] + a[i] + a[i + 1];
                }
            }
            return b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
/*

Define a function that removes duplicates from an array of non negative numbers and returns it as a result.

The order of the sequence has to stay the same.

Examples:

Input -> Output
[1, 1, 2] -> [1, 2]
[1, 2, 1, 1, 3, 2] -> [1, 2, 3]
 

  Duration: 13:23
 */
namespace Problems
{
    internal class RemoveDuplicatesFromList
    {
        public static int[] Solution1(int[] a)
        {
            int[] b = new int[a.Length];
            int indexB = 0;
            for(int i = 0; i < a.Length; i++)
            {
                bool isDuplicated = false;
                for(int e = 0; e < b.Length; e++)
                {
                    if (a[i] == b[e])
                    {
                        isDuplicated = true;
                    }
                }
                if(!isDuplicated)
                {
                    b[indexB] = a[i];
                    indexB++;
                }
                else
                {
                    Console.WriteLine("Es duplicado " + a[i]);
                }
            }
            Array.Resize(ref b,indexB);
            return b;
        }

        public static int[] Solution2(int[] a)
        {
            Dictionary<int, int> uniques = new();
            int[] b = new int[0];
            for(int i = 0; i < a.Length; i++)
            {
                bool containNumber = uniques.ContainsKey(a[i]);
                if (!containNumber)
                {
                    uniques.Add(a[i], 1);
                    Array.Resize(ref b, b.Length + 1);
                    b[b.Length - 1] = a[i];
                }
            }

            return b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class InsertionSort
    {
        static int[] InsSort(int[] Arr)
        {
            int n = Arr.Length;
            int i = 0;
            for (i = 0; i < n; i++)
            {

                int val = Arr[i];
                int j = i - 1;
                while (j >= 0 && Arr[j] > val)
                {
                    Arr[j + 1] = Arr[j];
                    j--;
                }
                Arr[j + 1] = val;
            }
            return Arr;
        }

        static void Main(string[] args)
        {
            int[] Arr = { 16, 43, 23, 54, 11, 45 };
            InsSort(Arr);
            Console.WriteLine("sorted array");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }
            Console.ReadLine();
        }
    }
}

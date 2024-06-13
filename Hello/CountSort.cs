using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class CountSort
    {
        static int[] CouSort(int[] Arr)
        {
            int n = Arr.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < 10; i++)
            {
                count[i] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                int index = Arr[i];
                count[index]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int index =Arr[i] ;
                output[count[index] - 1] = Arr[i];
                count[index]--;
            }

            for (int i = 0; i < n; i++)
            {
                Arr[i] = output[i];
            }

            return Arr;
        }

        static void Main(string[] args)
        {
            int[] Arr = { 3,1,6,8,3,7,3,1,5,8,9,5,2,3,6 };
            CouSort(Arr);
            Console.WriteLine("Sorted array");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }
            Console.ReadLine();
        }
    }
}

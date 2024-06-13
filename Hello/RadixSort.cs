using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class RadixSort
    {
        static int[] RadSort(int[] Arr)
        {
            int max = GetMax(Arr);

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                Arr = CountSort(Arr, exp);
            }

            return Arr;
        }

        static int GetMax(int[] Arr)
        {
            int max = Arr[0];
            foreach (int num in Arr)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        static int[] CountSort(int[] Arr, int exp)
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
                int index = (Arr[i] / exp) % 10;
                count[index]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int index = (Arr[i] / exp) % 10;
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
            int[] Arr = { 64, 25, 12, 22, 11,3,45,55 };
            RadSort(Arr);
            Console.WriteLine("Sorted array");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }
            Console.ReadLine();
        }

    }
}

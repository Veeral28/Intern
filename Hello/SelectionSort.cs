using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class SelectionSort
    {
        static int[] SelSort(int[] Arr)
        {
            int n = Arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                int j=0;
                for( j=i+1; j < n; j++)
                {
                    if (Arr[j] < Arr[min])
                    {
                        min = j;
                    }

                }
                int temp = Arr[min];
                Arr[min] = Arr[i];
                Arr[i] = temp;
            }
            return Arr;
        }

        static void Main(string[] args)
        {
            int[] Arr = { 64, 25, 12, 22, 11 };
            SelSort(Arr);
            Console.WriteLine("Sorted array");
            for (int i = 0;i < Arr.Length;i++)
            {
                Console.WriteLine(Arr[i]);
            }
            Console.ReadLine();
        }
    }
}

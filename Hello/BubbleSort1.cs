using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class BubbleSort1
    {
        static int[] BSort(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr.Length - 1; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        
                        int temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                    }
                }
            }
            return Arr;
        }
        static void Main(string[] args)
        {
            int[] Arr = { 64, 25, 12, 22, 11 };
            BSort(Arr);
            Console.WriteLine("Sorted array");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }
            Console.ReadLine();
        }
    }
}

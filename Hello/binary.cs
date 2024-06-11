using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class binary
    {
        static int BinSearch(int[] Arr, int n)
        {
            int low = 0;
            int high = Arr.Length;
            int mid;
            mid=low+(high-low)/2;
            while (low <= high) {
                if (Arr[mid] < n) {
                    low = mid + 1;
                    return mid;
                }
                else if (Arr[mid] > n)
                {
                    high = mid - 1;
                    return mid;
                }
                else
                {
                    return mid;
                }
            
            }
            return - 1;

        }
        static void main(string[] args)
        {
                int[] Arr = {1,2,3,4,5,6,7};

                int index = BinSearch(Arr, 5);
                Console.WriteLine("Index of 5: " + index); 
                Console.ReadLine();
            }

    }
}

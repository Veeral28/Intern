using System;

namespace Hello
{
    public class Linear
    {
        public int Linsearch(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void Main(string[] args)
        {
            int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Linear linearSearch = new Linear();
            int index = linearSearch.Linsearch(Arr, 3);
            Console.WriteLine("Index of 3: " + index);
            Console.ReadLine();
        }
    }
}

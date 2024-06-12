using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Quicksort
    {
        static int[] QSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QSort(array, low, pivotIndex - 1);
                QSort(array, pivotIndex + 1, high);
                
            }
            return array;

        }
        static int Partition(int[] array, int low, int high)
        {

            int pivot = array[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {

                if (array[j] <= pivot)
                {
                    i++;


                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }


            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }

        static void Main(string[] args)
        {
            int[] array = { 64, 25, 12, 22, 69, 21,55 };

            

            QSort(array, 0, array.Length - 1);

            Console.WriteLine("Sorted array is:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        
        }
    }
}

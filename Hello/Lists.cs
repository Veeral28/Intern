using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Lists
    {
        static void Main(string[] args)
        {
            List<string> food = new List<string>();
            food.Add("water");
            food.Add("apple");
            food.Add("papaya");
            food.Add("litchi");
            food.Add("mango");
            //food.Remove("mango")
            food.Insert(0, "juice");
            for (int i = 0; i < food[i].Length-1; i++)
            {
                Console.WriteLine(food[i] + " ");
            }
            Console.ReadLine();

        }
    }
}

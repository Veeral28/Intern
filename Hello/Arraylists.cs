using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hello
{
    internal class Arraylists
    {
        public static void Main(string[] args)
        {
            System.Collections.ArrayList myList = new System.Collections.ArrayList();
            
            myList.Add(1);
            myList.Add(2);
            myList.Add("water");
            myList.Add(true);

            Console.WriteLine(myList);
            //myList.Count();
            myList.Contains(true);
            myList.RemoveAt(0);

            Console.ReadLine();

        }
    }
}

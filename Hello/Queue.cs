using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Queue
    {
        static void Main(string[] args)
        {
            Queue<int> q1 = new Queue<int>();
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);
            q1.Enqueue(4);
            q1.Enqueue(5);
            q1.Enqueue(9);
            int q2 = q1.Count;
            int q3 = q1.Dequeue();
            Console.WriteLine(q2.ToString());
            Console.WriteLine(q2);
            Console.WriteLine(q3);
            Console.ReadLine();
        }
    }
}

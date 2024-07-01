using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class stack123
    {
        static void Main(string[] args)
        {
            Stack<int> stack1 = new Stack<int>();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Push(5);

            int slack =stack1.Pop();
            int stack2 = stack1.Pop();
            int stack3 = stack1.Peek();
            Console.WriteLine(slack);
            Console.WriteLine(stack2);
            Console.WriteLine(stack3);
            Console.ReadLine();
        }
    }

}

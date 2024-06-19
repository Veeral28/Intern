using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal interface Interface1
    {
        public void Hello();
    }


    public class Gel: Interface1
    {
        public void Hello() 
        {
        Console.WriteLine("Hello")
        }
}

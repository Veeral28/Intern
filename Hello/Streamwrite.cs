using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Streamwrite
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("texts.txt"))
            {
                Random r = new Random();
                for (int i = 1; i <= 5; i++)
                {
                    sw.WriteLine(r.Next(500, 6000));
                }
            }
        }
    }
}

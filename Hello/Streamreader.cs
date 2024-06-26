using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;
namespace Hello
{
    class Streamreader
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("texts.txt");

            int x;
            char ch;
            x = sr.Read();
            string line = sr.ReadLine();

            while (sr.Peek() != -1)
            {
                ch = (char)x;
                line = sr.ReadLine();

                x = sr.Read();
                Console.WriteLine(ch);
            }
            sr.Close();
            Console.ReadLine();
        }

    }
}

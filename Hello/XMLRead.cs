using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Hello
{
    class XMLRead
    {
        public static void Main(string[] args)
        {
            int totalC = 0;
            XmlDocument xmlDoc = new XmlDocument();
            string xmlPath = @"C:\Users\veera\source\repos\Hello\Hello\data11.xml";
            xmlDoc.Load(xmlPath);
            XmlNodeList Clist = xmlDoc.GetElementsByTagName("name");
            totalC = Clist.Count;
            if (!File.Exists(xmlPath))
            {
                Console.WriteLine("File not found: " + xmlPath);
                return;
            }

            for (int i = 0; i < totalC; i++)
            {
                Console.WriteLine(Clist[i].InnerText.ToString());
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(totalC.ToString()+"versions in XML file");
            Console.ReadLine();
        }
    }
}

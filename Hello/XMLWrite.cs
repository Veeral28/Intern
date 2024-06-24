using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Hello
{
    internal class XMLWrite
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            String names =Console.ReadLine();

            string path = @"C:\Users\veera\source\repos\Hello\Hello\datas11.xml";


            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);

            XmlNode profile = xmlDocument.CreateElement("Profile");
            XmlNode nameNode = xmlDocument.CreateElement("Name");
            nameNode.InnerText = names;
            profile.AppendChild(nameNode);

            xmlDocument.DocumentElement.AppendChild(profile);
            xmlDocument.Save(path);
            Console.WriteLine($"Name '{names}' added to XML file successfully.");

        }
    }
}

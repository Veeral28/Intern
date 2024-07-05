using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Hello
{
    public class XmlSerialization
    {
        public static void Main(string[] args)
        {
            Product product = new Product
            {
                id = 1,
                name = "Veeral",
                Natural = true,
                price = 23.45M,
                InventoryDate = DateTime.Now


            };



            XmlSerializer  xmlSerializer = new XmlSerializer(typeof(Product));
            using StringWriter sw = new StringWriter();
            xmlSerializer.Serialize(sw, product);
            Console.WriteLine(sw.ToString());
            Console.ReadLine();

        }

        public class Product
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool Natural { get; set; }
            public decimal price { get; set; }
            public DateTime InventoryDate { get; set; }
        }
    }
}

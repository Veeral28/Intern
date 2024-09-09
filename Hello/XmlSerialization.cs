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
            string xml = @"<?xml version=""1.0"" encoding=""utf-16""?>
<Product xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <id>1</id>
  <name>Veeral</name>
  <Natural>true</Natural>
  <price>23.45</price>
  <InventoryDate>2024-07-05T16:25:38.4860007+05:30</InventoryDate>
</Product>";
            //using StringWriter sw = SerializeObjecttoString(product);
            DeserializeStringToObject(xml);

        }

        private static Product DeserializeStringToObject(string xml)
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(Product));
            StringReader stringReader = new StringReader(xml);
            return xmlserializer.Deserialize(stringReader) as Product;
        }

        private static StringWriter SerializeObjecttoString(Product product)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
            StringWriter sw = new StringWriter();
            xmlSerializer.Serialize(sw, product);
            Console.WriteLine(sw.ToString());
            Console.ReadLine();
            return sw;
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

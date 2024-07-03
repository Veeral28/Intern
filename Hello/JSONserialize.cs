using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Text.Json;

namespace Hello
{
    internal class JSONserialize
    {
        static void Main(string[] args)
        {
            Product product = new Product
            {
                id = 1,
                name = "Veeral",
                Natural = true,
                price = 23.45M

            };
            string json = JsonSerializer.Serialize(product);
            Console.WriteLine(json);
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

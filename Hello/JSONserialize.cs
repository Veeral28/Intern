﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

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
                price = 23.45M,
                InventoryDate = DateTime.Now
                

            };
            //string json = JsonSerializer.Serialize(product, new JsonSerializerOptions{WriteIndented = true});
            //for newtonsoft 
            string json = JsonConvert.SerializeObject(product,Formatting.Indented);
            Console.WriteLine(json);
            Console.ReadLine();
            //Product newproduct = JsonSerializer.Deserialize<Product>(json);
            //Console.WriteLine(newproduct);
            Console.ReadLine() ;
        }
        public class Product
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool Natural { get; set; }
            public decimal price { get; set; }
            [JsonProperty("invdate")]
            public DateTime InventoryDate { get; set; }
        }
    }
}

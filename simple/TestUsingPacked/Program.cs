using System;
using Newtonsoft.Json;
using XTL;
using static XTL.Utils;

namespace Test
{
    class Product {
        public string Name { get; set; }
        public DateTime Expiry { get; set; }
        public string[] Sizes { get; set; }
    }
    class usingPacked
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new string[] { "Small" };

            string json = JsonConvert.SerializeObject(product);
            // {
            //   "Name": "Apple",
            //   "Expiry": "2008-12-28T00:00:00",
            //   "Sizes": [
            //     "Small"
            //   ]
            // }
            Console.WriteLine(json);
            
            
            string json1 = @"{
              'Name': 'Bad Boys',
              'Expiry': '1995-4-7T00:00:00',
              'Sizes': [
                'Big',
                'Small'
              ]
            }";

            var m = JsonConvert.DeserializeObject<Product>(json1);
            Console.WriteLine(m.Expiry);
            Console.WriteLine(string.Join(", ", m.Sizes));
            Console.WriteLine(m.Name);


            var kq = Utils.NumberToText(1290471473);
            Console.WriteLine(kq);
        }
    }
}


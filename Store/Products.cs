using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Products
    {
        public Products(string type, int price, string name)
        {
            Type = type;
            Price = price;
            Name = name;
        }

        public string Type { get; set; }
        public int Price { get; set; }

        public string Name { get; set; }

    }
}

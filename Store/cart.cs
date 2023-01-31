using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Cart
    {
        public List<Products> Products { get; set; }

        public Cart()
        {
            Products = new List<Products>();
        }

        public void Add(Products products)
        {
            Products.Add(products);
        }

        public void Delete(Products products)
        {
            Products.Remove(products);
        }



    }
}

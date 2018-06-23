using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Restaurant2

{
    public class ProductItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte Count { get; set; }
        public decimal TotalPrice { get; set; }
    }



    public class Basket
    {
        public List<ProductItem> ProductItems { get; set; }
        public Person Officiant { get; set; }
        public Basket()
        {
            ProductItems = new List<ProductItem>();
            Officiant = new Person();
        }
       
    }
}

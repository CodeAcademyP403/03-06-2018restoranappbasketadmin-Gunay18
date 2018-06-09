using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant2
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public byte Count { get; set; }
        public ProductCategory productCategory { get; set; }
        public int productID { get; set; }
    }
}

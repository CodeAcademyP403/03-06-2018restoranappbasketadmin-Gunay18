using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant2
{
    public class Person
    {
        public Person()
        {
            Name = "111";
            Password = "111";
            Orders = null;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { set; get; }
        public Role Role { get; set; }
        public List<ProductItem> Orders{ get; set; }
    }
}

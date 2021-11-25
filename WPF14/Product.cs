using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF14
{
    public enum ProductTypes
    {
        Food,
        Tech
    }
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public ProductTypes Category { get; set; }
    }
}

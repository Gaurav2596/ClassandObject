using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassDemo
{
    public class Product
    {
        private int prod_code, price;
        private string prod_name;

        
        public int Code
        {
            set { prod_code = value; }
            get { return prod_code; }
        }
        public int Price
        {
            set { price = value; }
            get { return price; }
        }
        public string Name
        {
            set { prod_name = value; }
            get { return prod_name; }
        }

        public override string ToString()
        {
            return $"Product name is {prod_name} :: Product code is{prod_code} :: Price is {price}";
        }
    }
}

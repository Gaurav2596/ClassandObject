using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassDemo
{
    public class productexam
    {
        private int bill, discount, afterDiscount;

        public productexam(int bill,int discount)
        {
                this.bill = bill;
                this.discount = discount;
        }
        public void Display()
        {
            afterDiscount = bill - (bill * discount / 100);
        }
        public override string ToString()
        {
            return $"Actual price is {bill}:\n Discounted price is {afterDiscount}";
        }
    }
}
    
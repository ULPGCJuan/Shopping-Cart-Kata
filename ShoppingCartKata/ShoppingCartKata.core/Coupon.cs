using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKata.business
{
    public class Coupon
    {
        public string Code { get; }
        public double DiscountPercentage { get; }

        public Coupon(string code)
        {
            Code = code;
            DiscountPercentage = 0.05;
        }
    }
}

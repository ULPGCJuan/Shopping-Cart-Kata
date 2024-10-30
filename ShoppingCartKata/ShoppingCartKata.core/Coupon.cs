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
            if (code == "PROMO_5")
            {
                DiscountPercentage = 0.05;
            }
            else if (code == "PROMO_10")
            {
                DiscountPercentage = 0.10;
            }
            else
            {
                DiscountPercentage = 0;
            }
        }
    }
}

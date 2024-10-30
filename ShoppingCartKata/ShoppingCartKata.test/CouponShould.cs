using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using ShoppingCartKata.business;

namespace ShoppingCartKata.test
{
    public class CouponShould
    {
        [TestCase("PROMO_5", 0.05)]
        [TestCase("PROMO_10", 0.10)]
        [TestCase("PROMO_15", 0)]
        public void Apply_correct_discount_based_on_code(string code, double expectedDiscount)
        {
            var coupon = new Coupon(code);

            coupon.DiscountPercentage.Should().Be(expectedDiscount);
        }
    }

    
}

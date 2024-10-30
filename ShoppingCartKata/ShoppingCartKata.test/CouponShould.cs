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
        [Test]
        public void Apply_five_percent_discount_for_PROMO_5_code()
        {
            var coupon = new Coupon("PROMO_5");

            coupon.DiscountPercentage.Should().Be(0.05);
        }

        [Test]
        public void Apply_ten_percent_discount_for_PROMO_10_code()
        {
            var coupon = new Coupon("PROMO_10");

            coupon.DiscountPercentage.Should().Be(0.10);
        }

        [Test]
        public void Apply_no_discount_for_any_other_code()
        {
            var coupon = new Coupon("PROMO_15");

            coupon.DiscountPercentage.Should().Be(0);
        }
    }

    
}

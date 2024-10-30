using ShoppingCartKata.core;
using FluentAssertions;

namespace ShoppingCartKata.test

{
    public class ProductShould
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Return_product_given_a_correct_product()
        {
            var name = "Lechuga";
            var cost = 1.55;
            var incomePercent = 0.15;
            var tax = 0.21;

            var product = new Product(name, cost, incomePercent, tax);

            product.Name.Should().Be("Lechuga");
            product.Cost.Should().Be(1.55);
            product.IncomePercent.Should().Be(0.15);
            product.Tax.Should().Be(0.21);
            product.FinalPrice.Should().Be(2.17);
        }
    }
}
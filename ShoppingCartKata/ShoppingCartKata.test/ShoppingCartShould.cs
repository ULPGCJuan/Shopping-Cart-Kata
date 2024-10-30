using ShoppingCartKata.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using ShoppingCartKata.business;

namespace ShoppingCartKata.test
{
    public class ShoppingCartShould
    {
        public ShoppingCart cart;


        [SetUp]
        public void Setup()
        {
            cart = new ShoppingCart();
            
        }

        [Test]
        public void Add_product_to_shopping_cart()
        {
            var product1 = new Product("Lechuga", 1.55, 0.15, 0.21);

            cart.AddItem(product1);
            cart.GetProducts().Count.Should().Be(1);

        }

        [Test]
        public void Return_empty_shopping_cart()
        {
            cart.GetProducts().Count.Should().Be(0);
        }

        [Test]
        public void Remove_product_from_shopping_cart_after_adding_a_product()
        {
            var product = new Product("Lechuga", 1.55, 0.15, 0.21);

            cart.AddItem(product);

            cart.GetProducts().Count.Should().Be(1);

            cart.RemoveItem(product);
            cart.GetProducts().Count.Should().Be(0);
        }
    }
}

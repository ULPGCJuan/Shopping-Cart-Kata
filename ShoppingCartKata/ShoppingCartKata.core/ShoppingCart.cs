using ShoppingCartKata.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKata.business
{
    public class ShoppingCart
    {
        private List<Product> ProductsList;

        public ShoppingCart()
        {
            ProductsList = new List<Product>();
        }

        public void AddItem(Product product)
        {
            ProductsList.Add(product);
        }

        public List<Product> GetProducts()
        {
            return ProductsList;
        }

        public void RemoveItem(Product product)
        {
            ProductsList.Remove(product);
        }
    }
}

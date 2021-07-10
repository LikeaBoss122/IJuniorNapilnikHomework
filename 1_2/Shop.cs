using System;
using System.Collections.Generic;

namespace _1_2.Homework
{
    class Shop
    {
        private Warehouse Warehouse;
        private List<Cart> Carts;
        
        public Cart Cart()
        {
            Cart newCart = new Cart(Warehouse);
            Carts.Add(newCart);
            return newCart;
        }

        public Shop(Warehouse warehouse)
        {
            if (warehouse == null)
                throw new InvalidOperationException();

            Carts = new List<Cart>();
            Warehouse = warehouse;
        }
    }
}

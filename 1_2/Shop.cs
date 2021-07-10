using System;
using System.Collections.Generic;

namespace _1_2.Homework
{
    class Shop
    {
        private Warehouse _warehouse;
        private List<Cart> _carts;
        
        public Cart Cart()
        {
            Cart newCart = new Cart(_warehouse);
            _carts.Add(newCart);
            return newCart;
        }

        public Shop(Warehouse warehouse)
        {
            if (warehouse == null)
                throw new InvalidOperationException();

            _carts = new List<Cart>();
            _warehouse = warehouse;
        }
    }
}

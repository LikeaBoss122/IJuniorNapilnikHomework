using System;

namespace _1_2.Homework
{
    class Cart : ThingsContainer
    {
        private Warehouse _shopWarehouse;
        private bool _ordered = false;

        public Cart(Warehouse warehouse)
        {
            if (warehouse == null)
                throw new InvalidOperationException();

            _shopWarehouse = warehouse;
        }

        public void Add(Good good, int count)
        {
            if (good == null || count <= 0)
                throw new InvalidOperationException();

            if (_shopWarehouse.HasNotThings(new Things(good, count)))
                throw new InvalidOperationException();

            ThingsList.Add(new Things(good, count));
        }

        public Order Order()
        {
            if (_ordered)
                throw new InvalidOperationException();

            Order ResultOrder = new Order(ThingsList);
            _ordered = true;

            return ResultOrder;
        }
    }
}

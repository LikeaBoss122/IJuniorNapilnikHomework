
using System.Collections.Generic;

namespace _1_2.Homework
{
    class Order : ThingsContainer
    {
        public string Paylink = "https://www.youtube.com/watch?v=0nR4fkISlgE";

        public Order(List<Things> things)
        {
            ThingsList = things;
        }
    }
}

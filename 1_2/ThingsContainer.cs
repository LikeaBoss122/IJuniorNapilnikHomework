using System;
using System.Collections.Generic;

namespace _1_2.Homework
{
    class ThingsContainer
    {
        protected List<Things> ThingsList = new List<Things>();

        public void WriteConsist()
        {
            foreach (Things item in ThingsList)
            {
                Console.WriteLine(item.Good.Name + " " + item.Count);
            }
        }
    }
}

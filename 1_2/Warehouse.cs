using System;

namespace _1_2.Homework
{
    class Warehouse : ThingsContainer
    {
        public void Delive(Good good, int count)
        {
            if (good == null || count <= 0)
                throw new InvalidOperationException();

            Things ThingsToAdd = new Things(good, count); 

            Things thingsToFeel = ThingsList?.Find(item => item.Good == good);

            if (thingsToFeel == null)
            {
                ThingsList.Add(ThingsToAdd);
                return;
            }

            thingsToFeel.AddGood(ThingsToAdd);
        }

        public bool HasNotThings(Things thingsToCheck)
        {
            if (thingsToCheck == null)
                throw new InvalidOperationException();

            Things ListThings = ThingsList.Find(item => item.Good == thingsToCheck.Good);

            if (ListThings == null || ListThings.Count < thingsToCheck.Count)
                return true;

            ListThings.WithdrawGood(thingsToCheck);

            return false;
        }
    }
}

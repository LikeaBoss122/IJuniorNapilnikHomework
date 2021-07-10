using System;

namespace _1_2.Homework
{
    class Things
    {
        public int Count { get; private set; }
        public readonly Good Good;

        public Things(Good good, int count)
        {
            if (good == null || count <= 0)
                throw new InvalidOperationException();

            Good = good;
            Count = count;
        }

        public void AddGood(Things thingsToAdd)
        {
            if (thingsToAdd.Good != Good || thingsToAdd.Count <= 0)
                throw new InvalidOperationException();

            Count += thingsToAdd.Count;
        }

        public void WithdrawGood(Things thingsToWithdraw)
        {
            if (thingsToWithdraw.Good != Good || thingsToWithdraw.Count <= 0)
                throw new InvalidOperationException();

            if (Count < thingsToWithdraw.Count)
                throw new InvalidOperationException();

            Count -= thingsToWithdraw.Count;
        }
    }
}

using System;

namespace _1_2.Homework
{
    class Good
    {
        public readonly string Name;

        public Good(string name)
        {
            if (name == null)
                throw new InvalidOperationException();

            Name = name;
        }
    }
}

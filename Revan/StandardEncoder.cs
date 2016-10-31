using System;

namespace Revan
{
    internal class StandardEncoder : IEncoder
    {
        public int mod;

        public StandardEncoder(int mod)
        {
            this.mod = mod;
        }

        public Tuple<int, int> encode(int value)
        {
            int mods = 0;
            int units = 0;

            while (value % this.mod != 0)
            {
                value -= 1;
                units += 1;
            }

            while (value != 0)
            {
                value -= this.mod;
                mods += 1;
            }

            return Tuple.Create(mods, units);
        }

        public Tuple<int, int> calculateRows(int amount)
        {
            int top, bottom;

            if (amount % this.mod == 0)
            {
                top = (amount / this.mod) - 1;
                bottom = this.mod - 1;
            } else
            {
                top = (amount - (amount % this.mod)) / 5;
                bottom = this.mod - 1;
            }

            return Tuple.Create(top, bottom);

        }
    }
}
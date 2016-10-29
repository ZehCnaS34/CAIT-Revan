using System;

namespace Revan
{
    internal class StandardEncoder : IEncoder
    {
        private Revan revan;

        public StandardEncoder(Revan revan)
        {
            this.revan = revan;
        }

        public Tuple<int, int> encode(int value)
        {
            int mods = 0;
            int units = 0;

            while (value % this.revan.mod != 0)
            {
                value -= 1;
                units += 1;
            }

            while (value != 0)
            {
                value -= this.revan.mod;
                mods += 1;
            }

            return Tuple.Create(mods, units);
        }

        public Tuple<int, int> calculateRows(int amount, int mod)
        {
            int top, bottom;

            if (amount % mod == 0)
            {
                top = (amount / mod) - 1;
                bottom = mod - 1;
            } else
            {
                top = (amount - (amount % mod)) / 5;
                bottom = mod - 1;
            }

            return Tuple.Create(top, bottom);

        }
    }
}
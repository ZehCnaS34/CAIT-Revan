using System;

namespace Revan
{
    internal class StandardEncoder : IEncoder
    {
        // Mod represents the hour/minute chunks of the clock. The default clock
        // implementation uses mod=5.
        private int mod;

        public StandardEncoder(int mod)
        {
            this.mod = mod;
        }

        // Encode calculates the number of lit bulbs according to the value specified in the
        // arguments.
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

        // Calculates the length of the rows.
        public Tuple<int, int> calculateRowLength(int amount)
        {
            int topRow, bottomRow;

            if (amount % this.mod == 0)
            {
                topRow = (amount / this.mod) - 1;
                bottomRow = this.mod - 1;
            } else
            {
                topRow = (amount - (amount % this.mod)) / this.mod;
                bottomRow = this.mod - 1;
            }

            return Tuple.Create(topRow, bottomRow);

        }
    }
}
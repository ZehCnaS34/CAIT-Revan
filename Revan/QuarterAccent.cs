using System;

namespace Revan
{
    class QuarterAccent : IAccent
    {
        public IBulb bulb;

        public QuarterAccent(IBulb bulb)
        {
            this.bulb = bulb;
        }

        IBulb IAccent.Bulb
        {
            get
            {
                return this.bulb;
            }
        }

        bool IAccent.check(int current, int max)
        {
            if ((Math.Ceiling(max*.25) == current) || 
                (Math.Ceiling(max *.50) == current) || 
                (Math.Ceiling(max *.75) == current))
            {
                return true;
            }

            return false;
        }
    }
}
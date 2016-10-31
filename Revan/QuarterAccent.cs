using System;

namespace Revan
{
    public class QuarterAccent : IAccent
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

        // Checks to see if the current index of the loop that called the method falls on a
        // quarter depending on the upperBound
        bool IAccent.check(int currentIndex, int upperBound)
        {
            if ((Math.Ceiling(upperBound * .25) == currentIndex) || 
                (Math.Ceiling(upperBound * .50) == currentIndex) || 
                (Math.Ceiling(upperBound * .75) == currentIndex))
            {
                return true;
            }

            return false;
        }
    }
}
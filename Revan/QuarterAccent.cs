using System;

namespace Revan
{
    class QuarterAccent : IAccent
    {
        public Revan revan;
        public IBulb display;

        public QuarterAccent(Revan revan, ROBulb display)
        {
            this.revan = revan;
            this.display = display;
        }

        IBulb IAccent.Display
        {
            get
            {
                return this.display;
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
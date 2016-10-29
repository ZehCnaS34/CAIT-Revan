using System;

namespace Revan
{
    class StandardFormatter : IFormatter
    {
        private Revan revan;

        public StandardFormatter(Revan revan)
        {
            this.revan = revan;
        }

        public void add(string p)
        {
            this.revan.output += p;
        }

        public void addBuffer()
        {
            this.revan.output += " ";
        }
    }
}
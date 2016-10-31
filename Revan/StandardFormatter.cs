using System;
using System.Text;

namespace Revan
{
    class StandardFormatter : IFormatter
    {
        private StringBuilder output;

        public StandardFormatter()
        {
            this.output = new StringBuilder();
        }

        public void add(string p)
        {
            this.output.Append(p);
        }

        public void addBuffer()
        {
            this.output.Append(" ");
        }

        public void reset()
        {
            this.output.Clear();
        }

        public string Output
        {
            get { return this.output.ToString(); }
        }
        
    }
}
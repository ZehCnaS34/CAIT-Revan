using System;
using System.Text;

namespace Revan
{
    public class StandardFormatter : IFormatter
    {
        private StringBuilder output;

        public StandardFormatter()
        {
            this.output = new StringBuilder();
        }

        // Adds a "Bulb" represented as a string to the string builder
        public void add(string p)
        {
            this.output.Append(p);
        }

        // Adds an space to the string builder
        public void addBuffer()
        {
            this.output.Append(" ");
        }

        // resets the string builder
        public void reset()
        {
            this.output.Clear();
        }

        // gets the output of the string builder
        public string Output
        {
            get { return this.output.ToString(); }
        }
        
    }
}
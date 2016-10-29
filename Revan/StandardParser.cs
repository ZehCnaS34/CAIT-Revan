using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revan
{
    class StandardParser : IParser
    {
        Revan inst;
        public StandardParser(Revan inst)
        {
            this.inst = inst;
        }

        HMS IParser.parse(Object o)
        {
            string input = (string)o;
            char[] delim = { ':' };
            HMS output = new HMS();

            string[] parts = input.Split(delim);

            output.hour = Int32.Parse(parts[0]);
            output.minute = Int32.Parse(parts[1]);
            output.second = Int32.Parse(parts[2]);

            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revan
{
    class CSParser : IParser
    {
        Revan inst;
        public CSParser(Revan inst)
        {
            this.inst = inst;
        }

        HMS IParser.parse(Object input)
        {
            DateTime dt = (DateTime)input;

            HMS output = new HMS();

            output.hour = dt.Hour;
            output.minute = dt.Minute;
            output.second = dt.Second;

            return output;
        }
    }
}

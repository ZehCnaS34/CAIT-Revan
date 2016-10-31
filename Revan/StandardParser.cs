using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revan
{
    public class StandardParser : IParser
    {
        /// <summary>
        /// Contains the code to extract the hours, minutes, and seconds out of a clock.
        /// </summary>
        /// <param name="o">the date object</param>
        /// <returns></returns>
        HMS IParser.parse(Object o)
        {
            try
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
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

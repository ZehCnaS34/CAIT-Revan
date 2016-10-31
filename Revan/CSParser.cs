using System;

namespace Revan
{
    class CSParser : IParser
    {
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

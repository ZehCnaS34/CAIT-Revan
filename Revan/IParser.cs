using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revan
{
    public interface IParser
    {
        HMS parse(object str);
    }

    public class HMS
    {
        public int hour;
        public int minute;
        public int second;
    }
}

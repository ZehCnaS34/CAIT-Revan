using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revan
{
    class YOBulb : IBulb
    {
        public string on()
        {
            return "Y";
        }

        public string off()
        {
            return "O";
        }
    }
}

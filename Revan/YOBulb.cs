using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revan
{
    class YOBulb : IBulb
    {
        string IBulb.on()
        {
            return "Y";
        }

        string IBulb.off()
        {
            return "O";
        }
    }
}

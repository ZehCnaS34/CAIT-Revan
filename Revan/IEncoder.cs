using System;

namespace Revan
{
    interface IEncoder
    {
        Tuple<int, int> calculateRows(int v, int mod);
        Tuple<int, int> encode(int hour);
    }
}
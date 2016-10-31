using System;

namespace Revan
{
    public interface IEncoder
    {
        Tuple<int, int> calculateRows(int v);
        Tuple<int, int> encode(int hour);
    }
}
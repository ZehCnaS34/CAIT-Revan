using System;

namespace Revan
{
    public interface IEncoder
    {
        Tuple<int, int> calculateRowLength(int v);
        Tuple<int, int> encode(int hour);
    }
}
namespace Revan
{
    interface IAccent
    {
        IBulb Display { get; }

        bool check(int i, int upperBound);
    }
}
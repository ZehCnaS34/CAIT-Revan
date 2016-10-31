namespace Revan
{
    public interface IAccent
    {
        IBulb Bulb { get; }

        bool check(int i, int upperBound);
    }
}
namespace Revan
{
    public interface IFormatter
    {
        string Output { get; }
        void add(string p);
        void addBuffer();
        void reset();
    }
}
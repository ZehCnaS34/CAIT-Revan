namespace Revan
{
    class ROBulb : IBulb
    {
        string IBulb.on()
        {
            return "R";
        }

        string IBulb.off()
        {
            return "O";
        }
    }
}

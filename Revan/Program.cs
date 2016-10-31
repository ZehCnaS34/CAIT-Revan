using System;


namespace Revan
{
    class Program
    {
        static void Main(string[] args)
        {

            var rv = new Revan();

            // Toggle comment to change the parser to one that recognizes C#'s DateTime Class
            // rv.Parser = new CSParser();

            // Toggle comment to change the 5 hour/minute chunks to 12 hour/minute chunks
            // rv.Encoder = new StandardEncoder(12);

            // Bulb is used to change the character that represents a bulb.
            // rv.Bulb = new ROBulb();

            // This is how we would change the color of the bulb located 3rd, 6th, 9th.
            // rv.Accent = new QuarterAccent(new YOBulb());

            // Formatter is where we would be able to convert the string output to an html output
            // rv.Formatter [not implemented]

            Console.WriteLine("Please enter the time in a 24-hour format [hh:mm:ss]: ");
            string timeString = Console.ReadLine();

            Console.WriteLine(rv.parse(timeString));


            Console.WriteLine("\n\nPress enter to quit.");
            Console.ReadLine();
        }
    }
}

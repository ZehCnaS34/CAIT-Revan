using System;


namespace Revan
{
    class Program
    {
        static void Main(string[] args)
        {

            var rv = new Revan();
            // The Default parser
            // rv.setParser(new CSParser(rv)); // Uncomment this line to enable C#'s DateTimeParser
            // rv.Parser = new CSParser(rv);

            Console.WriteLine("Please enter the time in a 24-hour format [hh:mm:ss]: ");
            string timeString = Console.ReadLine();

            Console.WriteLine(rv.parse(timeString));

            Console.WriteLine("\n\nPress enter to quit.");
            Console.ReadLine();
        }
    }
}

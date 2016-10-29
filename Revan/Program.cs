using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revan
{
    class Program
    {
        static void Main(string[] args)
        {
            var rv = new Revan();
            rv.setParser(new CSParser(rv));

            Console.WriteLine("Please enter the time in a 24-hour format [hh:mm:ss]: ");
            // string timeString = Console.ReadLine();

            Console.WriteLine(rv.parse(DateTime.Now));

            Console.WriteLine("\n\nPress enter to quit.");
            Console.ReadLine();
        }
    }
}

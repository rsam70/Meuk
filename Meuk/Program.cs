using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meuk
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Alpha, string Beta) namedLetters = ("a", "b");
            Console.WriteLine($"{namedLetters.Alpha}, {namedLetters.Beta}");

            var p = new Point(3.14, 2.71);
            (double X, double Y) = p;
        }
    }
}

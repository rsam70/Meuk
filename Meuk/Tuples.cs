using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meuk
{
    public class Point
    {
        public Point(double x, double y)
            => (X, Y) = (x, y);

        public double X { get; }
        public double Y { get; }

        public void Deconstruct(out double x, out double y) =>
            (x, y) = (X, Y);
    }
}

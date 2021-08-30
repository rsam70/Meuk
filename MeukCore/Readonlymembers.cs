using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeukCore
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);

        // check readonly state also of distance, (constness)
        public readonly override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";

        public /*readonly*/ void Translate(int xOffset, int yOffset)
        {
            X += xOffset;
            Y += yOffset;
        }
    }
}

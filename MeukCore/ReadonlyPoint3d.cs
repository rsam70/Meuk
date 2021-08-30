using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeukCore
{
    /// <summary>
    /// Ref readonly struct
    /// </summary>
    readonly public struct ReadonlyPoint3D
    {
        public ReadonlyPoint3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; }
        public double Y { get; }
        public double Z { get; }
    }

    public struct Point3D
    {
        private static Point3D origin = new Point3D(42, 43, 44);

        // Dangerous! returning a mutable reference to internal storage
        //public static ref Point3D Origin => ref origin;

        public static ref readonly Point3D Origin => ref origin;

        public Point3D(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        private double _x;
        public double X
        {
            readonly get => _x;
            set => _x = value;
        }

        private double _y;
        public double Y
        {
            readonly get => _y;
            set => _y = value;
        }

        private double _z;
        public double Z
        {
            readonly get => _z;
            set => _z = value;
        }

        public readonly double Distance => Math.Sqrt(X * X + Y * Y + Z * Z);

        public readonly override string ToString() => $"{X}, {Y}, {Z}";

        public void Dispose()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02
{
    // private static readonly
    public struct Point3D
    {
        private static readonly Point3D startCoordinates = new Point3D(0, 0, 0);
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D(int x, int y, int z):this()
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static Point3D ZeroCoordinate()
        {
            return startCoordinates;
        }
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
        }
    }



}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02
{
    static class TwoPoints3DDistance
    {
        public static double CalcDistance3D(Point3D first, Point3D second)
        {
            return Math.Sqrt((second.X - first.X) * (second.X - first.X) +
                (second.Y - first.Y) * (second.Y - first.Y) +
                (second.Z - first.Z) * (second.Z - first.Z));
        }
    }
}

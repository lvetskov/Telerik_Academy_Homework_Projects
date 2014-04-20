using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02
{
    public class Path
    {
        public List<Point3D> path = new List<Point3D>();

        public List<Point3D> Paths
        {
            get
            {
                return this.path;
            }
            set
            {
                this.path = value;
            }
        }

        public void AddPoint(Point3D point)
        {
            Paths.Add(point);
        }
        public void PrintPathList()
        {
            foreach (var item in path)
            {
                Console.WriteLine("({0}, {1}, {2})", item.X, item.Y, item.Z);
            }
        }
    }
}



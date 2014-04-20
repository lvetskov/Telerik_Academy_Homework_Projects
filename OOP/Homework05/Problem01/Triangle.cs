using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public class Triangle : Shapess
    {
        public Triangle(int width, int height):
            base (width, height)
        {

        }

        public override double CalculateSurface()
        {
            return this.Height * Width / 2;
        }
    }
}

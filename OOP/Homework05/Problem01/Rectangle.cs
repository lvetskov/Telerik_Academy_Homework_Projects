using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public class Rectangle: Shapess
    {
        public Rectangle(int width, int height):
            base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            return this.Height * Width;
        }
    }
}

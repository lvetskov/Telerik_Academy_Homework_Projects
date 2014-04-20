using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public class Circle: Shapess
    {
        public Circle(int radius):
            base (radius)
        {

        }


        public override double CalculateSurface()
        {
            return Math.PI * this.Width * 2;
        }
    }
}

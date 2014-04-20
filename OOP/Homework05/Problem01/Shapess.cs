using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    public abstract class Shapess
    {
        protected int Width { get; set; }
        protected int Height { get; set; }

        public Shapess(int width)
        {
            this.Width = width;
        }
        public Shapess(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateSurface();
    }
}

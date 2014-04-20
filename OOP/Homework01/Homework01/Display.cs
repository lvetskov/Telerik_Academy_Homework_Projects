using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    public class Display
    {
        private double? size;
        private int? coloursCount;
        
        public Display()
        {
        }

        public Display(double? size, int? coloursCount)
        {
            this.size = size;
            this.coloursCount = coloursCount;
        }


        public double? Size
        {
            get { return size; }
            set { size = value; }
        }
        public int? ColoursCount
        {
            get { return coloursCount; }
            set { coloursCount = value; }
        }
        
    }
}

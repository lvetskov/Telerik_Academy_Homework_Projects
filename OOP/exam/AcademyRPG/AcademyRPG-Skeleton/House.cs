using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class House : StaticObject
    {
        private const int initialHouseHitPoints = 500;
        public House(Point position, int owner)
            :base(position, owner)
        {
            this.HitPoints = initialHouseHitPoints;
        }      
    }
}

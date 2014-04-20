namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class PowerInhibitor : Supplement
    {
        private const int powerEffect = 3;
        private const int healthEffect = 0;
        private const int aggressionEffect = 0;
        public PowerInhibitor()
            : base(powerEffect, healthEffect, aggressionEffect)
        {
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
        }
    }
}

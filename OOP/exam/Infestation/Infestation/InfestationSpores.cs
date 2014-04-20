namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class InfestationSpores : Supplement
    {
        private const int powerEffect = -1;
        private const int healthEffect = 0;
        private const int aggressionEffect = 20;
        public InfestationSpores()
            : base(powerEffect, healthEffect, aggressionEffect)
        {
        }
        //To add implementing only once option to InfestationSpores!!!!!!!!!!!!

        public override void ReactTo(ISupplement otherSupplement)
        {
        }
    }
}

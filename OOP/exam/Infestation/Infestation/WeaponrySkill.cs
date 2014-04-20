namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class WeaponrySkill : Supplement
    {
        private const int powerEffect = 0;
        private const int healthEffect = 0;
        private const int aggressionEffect = 0;
        public WeaponrySkill()
            : base(powerEffect, healthEffect, aggressionEffect)
        {
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
        }
    }
}

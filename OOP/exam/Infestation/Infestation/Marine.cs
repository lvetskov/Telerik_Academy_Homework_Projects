namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Marine : Human
    {
        private WeaponrySkill weaponrySkill;
        public Marine(string Id)
            :base(Id)
        {
        }
        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, 0, int.MaxValue, 0);
            List<UnitInfo> lessOrEqualPowerUnits = new List<UnitInfo>();
            foreach (var unit in attackableUnits)
            {
                if (unit.Power <= optimalAttackableUnit.Power)
                {
                    lessOrEqualPowerUnits.Add(unit);
                }
            }
            if (lessOrEqualPowerUnits.Count >= 1 )
            {
                lessOrEqualPowerUnits.OrderBy(m => m.Health);
                optimalAttackableUnit = lessOrEqualPowerUnits[lessOrEqualPowerUnits.Count - 1];
            }
            else
            {
                optimalAttackableUnit = lessOrEqualPowerUnits[0];
            }
            return optimalAttackableUnit;
        }
    }
}

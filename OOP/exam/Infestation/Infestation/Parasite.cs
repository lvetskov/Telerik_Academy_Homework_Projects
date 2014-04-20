namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Parasite : InfestingUnit
    {
        private const int parasitePower = 1;
        private const int parasiteAggression = 1;
        private const int parasiteHealth = 1;
        private bool attackedOnce;

        public Parasite(string id)
            : base(id, UnitClassification.Biological, Parasite.parasiteHealth, Parasite.parasitePower, Parasite.parasiteAggression)
        {
            InfestationSpores infestationSpores = new InfestationSpores();
            this.attackedOnce = false;
        }
        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, 0, int.MaxValue, 0);
            List<UnitInfo> diffTypeOdUnits = new List<UnitInfo>();
            foreach (var unit in attackableUnits)
            {
                if (unit.GetType().Name != this.GetType().Name)
                {
                    diffTypeOdUnits.Add(unit);
                }
            }
            if (diffTypeOdUnits.Count >= 1)
            {
                diffTypeOdUnits.OrderBy(m => m.Health);
            }
            optimalAttackableUnit = diffTypeOdUnits[0];
            return optimalAttackableUnit;
            //To implement infestation to the attacked unit!
        }
        
    }
}

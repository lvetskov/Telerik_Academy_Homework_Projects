using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Giant : Character, IFighter, IGatherer
    {
        private const int initialGiantHitPoints = 200;
        private const int initialGiantDefensePoints = 80;
        private const int initialGiantAttackPoints = 150;
        private const int additionalAttackPointsFromGathering = 100;
        private const int neutralOwner = 0;
        private bool gatheredOnce;
        private int giantattackPoints;
        public Giant(string name, Point position)
            : base(name, position, neutralOwner)
        {
            this.HitPoints = initialGiantHitPoints;
            this.AttackPoints = initialGiantAttackPoints;
        }

        public int AttackPoints
        {
            get 
            {
                return giantattackPoints; 
            }
            set
            {
                this.giantattackPoints += value;
            }
        }

        public int DefensePoints
        {
            get { return initialGiantDefensePoints; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone && gatheredOnce == false)
            {
                gatheredOnce = true;
                this.AttackPoints = additionalAttackPointsFromGathering;
                return true;
            }

            return false;
        }
    }
}

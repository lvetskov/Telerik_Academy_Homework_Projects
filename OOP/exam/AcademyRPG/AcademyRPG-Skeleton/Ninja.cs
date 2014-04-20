using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character, IFighter, IGatherer
    {
        private const int initialNinjaHitPoints = 1;
        private const int invulnerableNinjaDefensePoints = int.MaxValue;
        private const int initialNinjaAttackPoints = 0;
        private const int stoneQuantityModifier = 2;
        private int ninjaAttackPoints;

        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = initialNinjaHitPoints;
            this.AttackPoints = initialNinjaAttackPoints;
        }

        public int AttackPoints
        {
            get 
            {
                return ninjaAttackPoints; 
            }
            set
            {
                this.ninjaAttackPoints += value;
            }
        }

        public int DefensePoints
        {
            get { return invulnerableNinjaDefensePoints; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            int highestHitPointsLocation = 0;
            for (int i = 0; i < availableTargets.Count; i++)
			{
                if (availableTargets[i].HitPoints > highestHitPointsLocation &&
                    availableTargets[i].Owner != this.Owner &&
                    availableTargets[i].Owner != 0)
                {
                    highestHitPointsLocation = i;
                    return highestHitPointsLocation;
                } 
			}
            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints = resource.Quantity * stoneQuantityModifier;
                return true;
            }
            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints = resource.Quantity;
                return true;
            }

            return false;
        }
    }
}

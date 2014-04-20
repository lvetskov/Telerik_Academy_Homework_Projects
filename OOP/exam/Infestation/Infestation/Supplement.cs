namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public abstract class Supplement : ISupplement
    {
        private int powerEffect;
        private int healthEffect;
        private int aggressionEffect;
        public Supplement(int powerEffect, int healthEffect, int aggressionEffect)
        {
            this.PowerEffect = powerEffect;
            this.HealthEffect = healthEffect;
            this.AggressionEffect = aggressionEffect;
        }
        
        public int PowerEffect
        {
            get 
            {
                return this.powerEffect;
            }
            private set
            {
                this.powerEffect = value;
            }
        }

        public int HealthEffect
        {
            
            get 
            {
                return this.healthEffect;
            }
            private set
            {
                this.healthEffect = value;
            }
        }

        public int AggressionEffect
        {
            get 
            {
                return this.aggressionEffect;
            }
            private set
            {
                this.aggressionEffect = value;
            }
        }
        public abstract void ReactTo(ISupplement otherSupplement);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class InfestingUnit : Unit
    {
        public InfestingUnit(string id, UnitClassification unitType, int health, int power, int aggression)
            :base(id, unitType, health, power, aggression)
        {
        }

        //To Implement infestation logic here!!!
    }
}

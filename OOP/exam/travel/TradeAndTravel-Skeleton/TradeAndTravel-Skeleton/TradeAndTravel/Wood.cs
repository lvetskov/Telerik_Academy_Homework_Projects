﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class Wood : Item
    {
        private const int generalWoodValue = 2;
        public Wood(string name, Location location = null):
            base(name, Wood.generalWoodValue, ItemType.Wood, location)
        {
        }
        public override void UpdateWithInteraction(string interaction)
        {
            if (interaction == "drop")
            {
                if (this.Value > 0)
                {
                    this.Value--;
                }
            }
            base.UpdateWithInteraction(interaction);
        }
    }
}

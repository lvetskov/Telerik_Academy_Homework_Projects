using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class HodingPenAdditionalObjects : HoldingPen
    {
        PowerInhibitor powerInhibitor = new PowerInhibitor();
        HealthInhibitor healthInhibitor = new HealthInhibitor();
        AggressionInhibitor aggressionInhibitor = new AggressionInhibitor();
        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Tank":
                    var tank = new Tank(commandWords[2]);
                    this.InsertUnit(tank);
                    break;
                case "Marine":
                    var marine = new Marine(commandWords[2]);
                    this.InsertUnit(marine);
                    break;
                case "Parasite":
                    var parasite = new Parasite(commandWords[2]);
                    this.InsertUnit(parasite);
                    break;
                case "Queen":
                    var queen = new Queen(commandWords[2]);
                    this.InsertUnit(queen);
                    break;
                default:
                    base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }
        }
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "PowerInhibitor":
                    Unit powerInhibitedUnit = GetUnit(commandWords[2]);
                    powerInhibitedUnit.AddSupplement(powerInhibitor);
                    break;
                case "HealthInhibitor":
                    Unit healthInhibitedUnit = GetUnit(commandWords[2]);
                    healthInhibitedUnit.AddSupplement(healthInhibitor);
                    break;
                case "AggressionInhibitor":
                    Unit aggresionInhibitedUnit = GetUnit(commandWords[2]);
                    aggresionInhibitedUnit.AddSupplement(aggressionInhibitor);
                    break;

                default:
                    break;
            }
        }


    }
}


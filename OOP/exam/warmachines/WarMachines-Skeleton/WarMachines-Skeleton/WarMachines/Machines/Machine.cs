﻿namespace WarMachines.Machines
{
    using WarMachines.Interfaces;
    using System.Collections.Generic;
    using System;
    public abstract class Machine : IMachine
    {
        protected const string On = "ON";
        protected const string Off = "OFF";
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private IList<string> targets;

        public Machine(string name, double healthPoints, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.Targets = new List<string>();

        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                  //  throw new ArgumentNullException("Machine name cannot be null or empty.");
                }
                this.name = value;
            }
        }        
        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Pilot cannot be null.");
                }
                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IList<string> Targets
        {
            get 
            {
                return new List<string>(targets); 
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("List of targets cannot be null.");
                }
                this.targets = value;
            }
        }
        public void Attack(string target)
        {
            if (target == null)
            {
                throw new ArgumentNullException("Target cannot be null or empty.");
            }
            this.targets.Add(target);
        }

        private string CheckTargetList(IList<string> TargetList)
        {
            if (TargetList.Count == 0)
            {
                return "None";
            }
            else
            {
                return string.Join<string>(", ", TargetList);
            }
        }
        public override string ToString()
        {
            var result = string.Format("- {0}\n *Type: {1}\n *Health: {2}\n *Attack: {3}\n *Defense: {4}\n *Targets: {5}",
                this.Name, this.GetType().Name, this.HealthPoints, this.AttackPoints, this.DefensePoints, CheckTargetList(this.Targets));
            return result;
        }
    }
}

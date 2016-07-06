namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private double healthPoints;
        private string name;
        private double defensePoints;
        private double attackPoints;
        private IPilot pilot;
        private IList<string> targets;

        public Machine(string name, double attackPoints, double defensePoints, IPilot pilot = null)
        {
            this.name = name;
            this.attackPoints = attackPoints;
            this.defensePoints = defensePoints;
            this.pilot = pilot;
            this.targets = new Collection<string>();

        }

        public virtual double AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            protected set
            {
                this.attackPoints = value;
            }
        }

        public virtual double DefensePoints
        {
            get
            {
                return this.defensePoints;
            }
            protected set
            {
                this.defensePoints = value;
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

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
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
                if (value != null)
                {
                    this.pilot = value;
                }
            }
        }

        public IList<string> Targets
        {
            get
            {
                return new Collection<string>(this.targets);
            }
        }

        public void Attack(string target)
        {
            if (!targets.Contains(target))
            {
                targets.Add(target);
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendLine(String.Format("- {0}", this.name));
            output.AppendLine(String.Format(" *Type: {0}", this.GetType().Name.ToString()));
            output.AppendLine(String.Format(" *Health: {0}", this.HealthPoints));
            output.AppendLine(String.Format(" *Attack: {0}", this.attackPoints));
            output.AppendLine(String.Format(" *Defense: {0}", this.defensePoints));
            output.AppendLine(String.Format(" *Targets: {0}", targets.Count > 0 ? String.Join(", ", targets) : "None"));
            return output.ToString();
        }
    }
}
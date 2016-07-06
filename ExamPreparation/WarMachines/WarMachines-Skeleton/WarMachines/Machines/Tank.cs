namespace WarMachines.Machines
{
    using System;
    using System.Text;
    using WarMachines.Interfaces;

    public class Tank : Machine, ITank
    {
        private const double TankInitialHealthPoints = 100;
        private bool defenseMode;

        public Tank(string name, double attackPoints, double defensePoints, IPilot pilot = null)
            : base(name, attackPoints, defensePoints, pilot)
        {
            base.HealthPoints = TankInitialHealthPoints;
            this.ToggleDefenseMode();
        }

        public bool DefenseMode
        {
            get
            {
                return this.defenseMode;
            }
        }

        public void ToggleDefenseMode()
        {
            if (defenseMode)
            {
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
                this.defenseMode = false;
            }
            else
            {
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
                this.defenseMode = true;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.Append(base.ToString());
            output.Append(String.Format(" *Defense: {0}", defenseMode ? "ON" : "OFF"));
            return output.ToString();
        }
    }
}

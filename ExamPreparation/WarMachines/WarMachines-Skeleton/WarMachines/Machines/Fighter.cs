namespace WarMachines.Machines
{
    using System;
    using System.Text;
    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter
    {
        private const double FighterHealthPoints = 200;

        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode, IPilot pilot = null) : base(name, attackPoints, defensePoints, pilot)
        {
            base.HealthPoints = FighterHealthPoints;
            this.stealthMode = stealthMode;
        }

        public bool StealthMode
        {
            get
            {
                return this.stealthMode;
            }
            private set
            {
                this.stealthMode = value;
            }
        }

        public void ToggleStealthMode()
        {
            if (stealthMode)
            {
                this.stealthMode = false;
            }
            else
            {
                this.stealthMode = true;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.Append(base.ToString());
            output.Append(String.Format(" *Stealth: {0}", stealthMode ? "ON" : "OFF"));
            return output.ToString();
        }
    }
}

namespace WarMachines
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines;

        public Pilot(string name)
        {
            this.name = name;
            this.machines = new Collection<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (!String.IsNullOrEmpty(machine.Name))
            {
                this.machines.Add(machine);
            }
        }

        public string Report()
        {

            var output = new StringBuilder();
            output.Append(String.Format("{0} - {1} {2}", this.name, this.machines.Count > 0 ? this.machines.Count.ToString() : "no", this.machines.Count == 1 ? "machine" : "machines"));
            var newList = this.machines.OrderBy(x => x.HealthPoints).ThenByDescending(x => x.Name).ToList();
            foreach (var item in newList)
            {
                output.AppendLine();
                output.Append(item.ToString());
            }
            return output.ToString();
        }
    }
}

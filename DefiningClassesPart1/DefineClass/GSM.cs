namespace DefineClass
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private string model;             //fields
        private string manufacturer;
        private string price;
        private string owner;
        private Battery battery;
        private Display display;
        private static GSM iPhone4S = new GSM("iPhone4S", "Apple", "900$", "Ivan Ivanov", new Battery("thin", "100hoursIdle", "20hoursTalk"), new Display("7inches", "10kColors"));
        private List<Call> callHistory = new List<Call>();

        //constructors
        public GSM()
        {

        }

        public GSM(string model, string manufacturer, string price = null, string owner = null, Battery battery = null, Display display = null) //constructor
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.display = display;
            this.battery = battery;
        }

        //propertys
        public static GSM Iphone4S
        {
            get { return iPhone4S; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public string Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }
        //method
        public override string ToString()
        {

            return

                string.Format(
                              "---This Device is produced by-> {0} <-,model-> {1} <-,market price-> {2} <-, the owner is-> {3} <-\n---Other specifications: battery-hours to talk-> {4} <-, display size-> {5} <-",
                              this.manufacturer,
                              this.model,
                              this.price,
                              this.owner,
                              this.battery.HoursTalk,
                              this.display.Size);
        }

        public void AddCall(Call newCall)
        {
            this.callHistory.Add(newCall);
        }

        public void DeleteCall(Call callToDelete)
        {

            if (!this.callHistory.Contains(callToDelete))
            {
                return;
            }

            this.callHistory.Remove(callToDelete);
        }

        public decimal TotalCallPrice(decimal pricePerMinute)
        {
            var totalSeconds = 0;

            foreach (var call in this.callHistory)
            {
                totalSeconds += call.DurationInSeconds;
            }

            decimal price = totalSeconds * (pricePerMinute / 60m);

            return price;
        }
        public void CallHistoryPrint()
        {

            if (this.callHistory.Count == 0)
            {
                Console.WriteLine("Call history is empty!");
            }
            else
            {
                Console.WriteLine("Date\t\tTime\t\tDailed number\t\tDuration seconds\n");

                foreach (var call in this.CallHistory)
                {
                    Console.Write("{0}\t\t{1}\t\t{2}", call.DateTime, call.DialledNumber, call.DurationInSeconds);
                    Console.WriteLine();
                }
            }
        }
    }
}

namespace DefineClass
{
    public class Battery
    {
        private string model;      //fields
        private string hoursIdle;
        private string hoursTalk;
        private BatteryType type;

        public Battery()      //basic constructor
        {

        }
        public Battery(string model, string hoursIdle, string hoursTalk, BatteryType type = BatteryType.NiCd) //constructor for all characteristics
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }
        public string HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }
        public BatteryType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}

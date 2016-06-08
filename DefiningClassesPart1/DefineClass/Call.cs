namespace DefineClass
{
    using System;

    public class Call
    {
        public Call(DateTime dateTime, string dialledNumber, int durationInSeconds)
        {
            this.DateTime = dateTime;
            this.DialledNumber = dialledNumber;
            this.DurationInSeconds = durationInSeconds;
        }

        public DateTime DateTime { get; set; }

        public string DialledNumber { get; set; }

        public int DurationInSeconds { get; set; }
    }
}

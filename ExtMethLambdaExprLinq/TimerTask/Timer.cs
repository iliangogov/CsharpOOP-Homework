namespace TimerTask
{
    using System;
    using System.Threading;

    public delegate void Ticker();
    public class Timer
    {
        public static readonly Action Action = new Action(() => Console.Write(++Seconds));
        public static int Seconds { get; private set; }
    }
}

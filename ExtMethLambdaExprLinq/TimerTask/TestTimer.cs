namespace TimerTask
{
    using System;
    using System.Threading;

    class TestTimer
    {
        static void Main()
        {
            var ticker = new Ticker(Timer.Action);
            int counter = 10;
            while (counter > 0)
            {
                ticker();
                Thread.Sleep(1000);
                Console.Clear();
                counter--;
            }
        }
    }
}

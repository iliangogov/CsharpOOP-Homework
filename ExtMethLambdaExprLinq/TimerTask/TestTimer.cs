namespace TimerTask
{
    using System;
    using System.Threading;

    class TestTimer
    {
        static void Main()
        {
            //var ticker = new Ticker(Timer.Action);
            int counter = 0;
            while (counter <= 10)
            {
                // ticker();
                Console.WriteLine(counter);
                Thread.Sleep(1000);
                Console.Clear();
                counter++;
            }
        }
    }
}

using System;

namespace DefineClass
{
    class Program
    {
        static void Main()
        {
               //demo
            var phone = new GSM("iPhone4S", "Apple", "900$", "Ivan Ivanov", new Battery("thin", "100hoursIdle", "20hoursTalk"), new Display("7inches", "10kColors"));
            phone.Battery = new Battery();
            phone.Display = new Display();
            phone.Battery.Type = BatteryType.NiMh;           
           Console.WriteLine( phone.ToString());

            Console.WriteLine();

            var gsmExample = new GSMTest();
            gsmExample.DisplayGsmInfo();

            Console.WriteLine();

            var historyTest = new GSMCallHistoryTest();
            historyTest.Functionality();

            Console.WriteLine();
            phone.AddCall( new Call(new DateTime(2016, 05, 24, 10, 30, 20), "0888 11 22 33", 200));
            phone.CallHistoryPrint();
            

        }
    }
}

namespace DefineClass
{
    using System;
    using System.Linq;

    class GSMCallHistoryTest
    {
        private GSM exampleGSM = new GSM("iPhone", "Apple");
        private const decimal PricePerMinute = 0.37m;

        public void Functionality()
        {
            exampleGSM.AddCall(new Call(new DateTime(2016, 06, 01, 10, 30, 15), "0888 11 11 11", 120));
            exampleGSM.AddCall(new Call(new DateTime(2016, 06, 02, 11, 20, 55), "0888 22 22 22", 260));
            exampleGSM.AddCall(new Call(new DateTime(2016, 06, 03, 12, 10, 05), "0888 33 33 33", 330));
            exampleGSM.AddCall(new Call(new DateTime(2016, 06, 04, 13, 45, 25), "0888 44 44 44", 440));
            exampleGSM.AddCall(new Call(new DateTime(2016, 06, 05, 14, 17, 00), "0888 55 55 55", 500));

            exampleGSM.CallHistoryPrint();
            Console.WriteLine();
            Console.WriteLine("Total price: {0:f2} Lv.", exampleGSM.TotalCallPrice(PricePerMinute));

            Call longestCall = exampleGSM.CallHistory.OrderByDescending(x => x.DurationInSeconds).First();

            exampleGSM.DeleteCall(longestCall);

            Console.WriteLine(
                "Total price after removing longest call is {0:f2} lv. ",
                exampleGSM.TotalCallPrice(PricePerMinute));

            exampleGSM.CallHistory.Clear();

            exampleGSM.CallHistoryPrint();
        }
    }
}

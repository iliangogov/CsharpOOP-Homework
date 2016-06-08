namespace DefineClass
{
    using System;

    public class GSMTest
    {
        private GSM[] gsmExample =
                 {
                new GSM("Iphone 5", "Apple", "500$", "Stefan", new Battery(), new Display()),
                new GSM("Galaxy Edge", "Samsung", "700$", "Gencho", new Battery(), new Display()),
                new GSM("Lumia", "Nokia","400$", "Georgi", new Battery(), new Display())
            };

        public void DisplayGsmInfo()
        {
            foreach (var gsm in gsmExample)
            {
                Console.WriteLine(gsm.ToString());
            }

            Console.WriteLine(GSM.Iphone4S.ToString());
        }
    }
}

using System;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var testeo = new Tester();
            // Flujo de trabajo.
            testeo.StartBrowser()
                    .RunTest("https://www.google.com.mx")
                    .Wait(5000);
            // Fin del flujo de trabajo.
            testeo.CloseBrowser();
            Console.ReadLine();
        }
    }
}

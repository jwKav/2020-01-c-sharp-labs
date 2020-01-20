using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace lab_04_debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"C:\log\log.dat", ""); //clears log file
            int x = 10;
            x = x + 10;
            int y = x * x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Trace.WriteLine($"Trace WriteLine is {i}");
                Debug.WriteLine($"Debug WriteLine is {i}");
                Debug.WriteLineIf(i == 6, "Hey, i is 6!");
                //File.AppendAllText("../log.dat", $"Logging i={i} at {DateTime.Now}");
                Console.WriteLine("\\");    // \ is an escaped character
                
                File.AppendAllText(@"C:\log\log.dat", $"\nLogging i={i} at {DateTime.Now}");
                // note: \ is a special character
                // use @ to provide clean string literal
                Thread.Sleep(1500);

            }
            //print file
            var logFilePath = @"C:\log\log.dat";
            Console.WriteLine("\n\nPrinting contents of log file\n\n");
            Console.WriteLine(File.ReadAllText(logFilePath));


        }
    }
}

using System;
using System.Threading;

namespace ConsoleApptest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the text you want to be printed out");
            var textToPrint = Console.ReadLine();
            Console.WriteLine("this is the text to be printed: {0}", textToPrint.ToString());
            string SysInfo = System.DateTime.Today.ToString();
            Console.WriteLine("this is the current time: {0}", SysInfo);
            //This are the building blocks for a clock feature
            for (int x=0; x < 10; x++) {
                Thread.Sleep(1000);
                Console.WriteLine("Count: {0}",x);
            }
        }
    }
}

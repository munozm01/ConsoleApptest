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
            //This are the building blocks for a clock feature
            for (int x=0; x < 10; x++) {
                Thread.Sleep(1000);
                Console.WriteLine("Clock: {0}:{1}:{2}",
                                  System.DateTime.Today.Hour.ToString(),
                                  System.DateTime.Today.Minute.ToString(),
                                  System.DateTime.Today.Second.ToString());
            }
        }
    }
}

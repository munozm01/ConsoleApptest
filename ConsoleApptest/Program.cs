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
<<<<<<< Updated upstream
            string SysInfo = System.DateTime.Today.ToString();
            Console.WriteLine("this is the current time: {0}", SysInfo);
            //This are the building blocks for a clock feature
=======
>>>>>>> Stashed changes
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

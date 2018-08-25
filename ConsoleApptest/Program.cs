using System;

namespace ConsoleApptest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the text you want to be printed out");
            var textToPrint = Console.ReadLine();
            Console.WriteLine("this is the text to be printed: {0}", textToPrint.ToString());
        }
    }
}

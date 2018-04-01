using System;

namespace VelibSoapClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            (new Prompt()).Run().Wait();
        }
    }
}

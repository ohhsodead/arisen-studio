using System;
using XDevkit;

namespace UnitTests
{
    class Program
    {
        public static Xbox XboxConsole;

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            if (XboxConsole.Connect(out XboxConsole, "default"))
            {
                Console.WriteLine($"connected");
            }
            else
            {
                Console.WriteLine($"Can't connect to console");
                return;
            }

            Console.Read();
        }
    }
}

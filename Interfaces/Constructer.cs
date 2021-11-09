using System;

namespace Coding
{
    class Constructer : IContract
    {
        public static string Name { get; set; }
        public static int Age { get; set; }

        public static void PaperWork()
        {
            Console.WriteLine($"{Name} is working");
        }
    }
}
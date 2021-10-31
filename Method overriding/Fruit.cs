using System;

namespace Coding
{
    public class Fruit
    {
        public string color { get; set; }

        public virtual void display()
        {
            Console.WriteLine($"Color is {color}");
        }
    }
}
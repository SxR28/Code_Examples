using System;

namespace Coding
{
    public class Orange : Fruit
    {
        public override void display()
        {
            base.display();
            Console.WriteLine($"Color is orange");
        }
    }
}
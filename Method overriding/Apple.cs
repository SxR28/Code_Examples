using System;
using System.ComponentModel.DataAnnotations;

namespace Coding
{
    public class Apple : Fruit
    {
        public override void display()
        {
            Console.WriteLine($"Color is red");
        }
    }
}
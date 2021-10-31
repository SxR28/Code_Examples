using System;
using System.Reflection.Metadata;

namespace Coding
{
    class Program
    {
        static Orange orangeFruit = new Orange();
        static Apple appleFruit = new Apple();
        
        static void Main(string[] args)
        {
            orangeFruit.display();
            appleFruit.display();
        }
    }
}

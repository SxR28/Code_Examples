using System;

namespace Coding
{
    public interface IContract
    {
        static string Name { get; set; }
        
        static int Age { get; set; }

        static void PaperWork()
        {
            
        }
    }
}
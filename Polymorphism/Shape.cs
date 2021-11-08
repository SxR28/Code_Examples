using System;

namespace Coding
{
    public class Shape
    {
        public int width { get; set; }
        public int height { get; set; }
        
        public int area { get; set; }

        public virtual void ShapeDrawing()
        {
            Console.WriteLine("Drawing a shape");
        }
    }
}
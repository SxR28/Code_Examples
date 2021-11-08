using System;
using System.Drawing;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListOfShapes = new List<Shape>
            {
                new Circle(),
                new Square(),
                new Triangle()
            };
            
            foreach (var shape in ListOfShapes)
                shape.ShapeDrawing();
        }
    }
}

using System;

namespace Coding
{
    public class Circle : Shape
    {
        public override void ShapeDrawing()
        {
            base.ShapeDrawing();
            Console.WriteLine("Drawing a circle, stay steady");
        }
    }

    public class Triangle : Shape
    {
        public override void ShapeDrawing()
        {
            base.ShapeDrawing();
            Console.WriteLine("Drawing a triangle");
        }
    }

    public class Square : Shape
    {
        public override void ShapeDrawing()
        {
            base.ShapeDrawing();
            Console.WriteLine("Drawing a square");
        }
    }
}
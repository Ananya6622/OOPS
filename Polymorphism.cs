using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsPrograms
{
    class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing...");
        }
    }
    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle..");
        }
    }
    class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle..");
        }
    }
    public class Polymorphism
    {
        public static void Main()
        {
            Shape shape;
            shape = new Shape();
            shape.draw();
            shape = new Rectangle();
            shape.draw();
            shape = new Circle();
            shape.draw();
        }
    }
}

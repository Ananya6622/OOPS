using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsPrograms
{
    abstract class Shapes
    {
        public abstract void Draw();
    }
    class Square : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle...");
        }
    }
    public class Abstraction
    {
        public static void main()
        {
            Square square = new Square();
            square.Draw();
        }
    }
}

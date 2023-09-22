using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsPrograms
{
    class Animals
    {
        public void eat()
        {
            Console.WriteLine("eating..");
        }
    }
    class Dogs: Animals
    {
        public void bark()
        {
            Console.WriteLine("barking...");
        }
    }
    public class SingleLevelInheritance
    {
        public static void main()
        {
            Dogs dogs = new Dogs();
            dogs.eat();
            dogs.bark();
        }
    }
}

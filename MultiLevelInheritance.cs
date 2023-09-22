using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsPrograms
{
    class Animalss
    {
        public void eat()
        {
            Console.WriteLine("eating..");
        }
    }
    class Dogss : Animals
    {
        public void bark()
        {
            Console.WriteLine("barking...");
        }
    }
    class BabyDogs : Dogss
    {
        public void weep()
        {
            Console.WriteLine("weeping...");
        }
    }

    public class MultiLevelInheritance
    {
        public static void main()
        {
            BabyDogs babyDogs = new BabyDogs();
            babyDogs.eat();
            babyDogs.bark();
            babyDogs.weep();
        }
    }
}

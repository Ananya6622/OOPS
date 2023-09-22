using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsPrograms
{
    class Animal
    {
        public void eat()
        {

            Console.WriteLine("Eating..");
        }
    }
    class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking...");
        }
    }
    public class Inheritance
    {
        public static void Main()
        {
            Dog dog1 = new Dog();
            dog1.bark();
            dog1.eat();
        }
    }
}

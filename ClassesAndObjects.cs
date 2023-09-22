using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsPrograms
{
    class Student
    {
        public String Name;
        public int Age;
        public void DisplayInfo()
        {
            Console.WriteLine($"Name:{Name}, Age:{Age}");
        }
    }
    public class ClassesAndObjects
    {
        public static void Main()
        {
            Student student1 = new Student();
            student1.Name = "Ananya";
            student1.Age = 22;
            student1.DisplayInfo();

            Student student2 = new Student();
            student1.Name = "Suhas";
            student1.Age = 22;
            student1.DisplayInfo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsPrograms
{
    public class Types
    {
        public static void ModifyValue(int val)
        {
            val = 10;
        }
        public static void ModifyReference(int[] arr)
        {
            arr[0] = 10;
        }
        public static void main()
        {
            int num = 5; // Value type
            ModifyValue(num);
            Console.WriteLine($"Value type: {num}"); 

            int[] numbers = { 1, 2, 3 }; // Reference type
            ModifyReference(numbers);
            Console.WriteLine($"Reference type: {numbers[0]}");
        }
    }
}

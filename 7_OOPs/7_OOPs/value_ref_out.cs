using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOPs
{
    internal class value_ref_out
    {
        public static void Run()
        {
            Console.WriteLine("Passing argument by value");
            int a = 5;
            IncrementByValue(a); // 15
            Console.WriteLine($"The value of a is {a}"); // 5

            Console.WriteLine("Passing argument by ref");
            int b = 87;
            IncrementByRef(ref b); // 97
            Console.WriteLine($"The value of b is {b}"); // 97 

            Console.WriteLine("Out keyword");
            string name;
            TakeInput(out name);
            Console.WriteLine(name);
        }
        static void IncrementByValue(int num)
        {
            num += 10; // num = num + 10
            Console.WriteLine($"Incremented value in function is {num}");
        }
        static void IncrementByRef(ref int num)
        {
            num += 10; // num = num + 10
            Console.WriteLine($"Incremented value in function is {num}");
        }
        static void TakeInput(out string x)
        {
            x = "Farooq";
            Console.WriteLine(x);
        }
    }
}

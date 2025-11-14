using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_functions_methods
{
    internal class StaticNonStatic
    {
        public static void Perform()
        {
            Console.WriteLine("Hello, World!");

            Maths m1 = new Maths();

            m1.Add(2, 3);

            Maths.Subtract(2, 3);

            // Maths.Add(2, 5); // compile time error
        }
    }

    class Maths
    {
        // non-static / instance
        public void Add(int a, int b)
        {
            int result = a + b;

            Console.WriteLine("The sum is " + result);
        }
        // static / class
        static public void Subtract(int a, int b)
        {
            int result = a - b;

            Console.WriteLine("The subtract is " + result);
        }
    }
}

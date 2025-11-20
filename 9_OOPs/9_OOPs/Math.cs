using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_OOPs
{
    internal class Math
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine($"Sum => {a} + {b} = {a + b}");
        }
        public void Sum(int a, int b, int c)
        {
            Console.WriteLine($"Sum => {a} + {b} + {c} = {a + b + c}");
        }
        public void Sum(int a, int b, int c, int d)
        {
            Console.WriteLine($"Sum => {a} + {b} + {c} + {d} = {a + b + c + d}");
        }
    }
}

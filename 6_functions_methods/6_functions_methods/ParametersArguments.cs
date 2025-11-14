using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_functions_methods
{
    internal class ParametersArguments
    {
        public static void Perform()
        {
            Greet("2212E1");
            Greet();
            Greet("2410F1");

            // arguments order
            // 1. positional
            PrintDetails("Farooq", "Daniyal", 19);
            PrintDetails("Daniyal", "Farooq", 19);

            // PrintDetails(19, "Ahmed", "Farooq");

            // 2. named
            PrintDetails(age: 19, lname: "Daniyal", fname: "Farooq");

            // return type
            Console.WriteLine(Max(44, 98));
            Console.WriteLine(Max(23, 3));
        }
        // Parameter & Argument
        // Parameterized & Non-Parateremized
        // required parameter
        // optional parameter -- default value
        static void Greet(string batchCode = "2410F1")
        {
            Console.WriteLine($"Welcome, {batchCode}");

        }

        static void PrintDetails(string fname, string lname, int age)
        {
            Console.WriteLine($"Your full name is {fname} {lname}.");
            Console.WriteLine($"You are {age} years old.");
        }

        static int Max(int a, int b)
        {
            //if(a > b)
            //{
            //    return a;
            //}
            //else
            //{
            //    return b;
            //}

            return a > b ? a : b;
        }
    }
}

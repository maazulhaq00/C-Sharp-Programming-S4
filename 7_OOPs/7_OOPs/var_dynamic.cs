using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOPs
{
    internal class var_dynamic
    {
        public static void Run()
        {
            int a; // declaration
            a = 3; // assignment

            //int b = 3;

            var name = "Ali";
            name = "Saad";

            // name = 3; // error - compile time


            // dynamic
            dynamic my_variable;
            my_variable = "Ali";
            my_variable = true;
        }

        //var fun1( var a) // incorrect
        //{

        //}
        dynamic fun1(dynamic a)
        {
            return "Hello";
        }
    }
}
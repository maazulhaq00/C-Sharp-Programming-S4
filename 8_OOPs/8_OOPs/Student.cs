using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOPs
{
    class Student
    {
        // properties

        public static string instituteName = "Aptech Learning";
        int rollno;
        string name;
        int age;
        int standard;

        //default constructor , non parameterized
        //public Student()
        //{
        //    this.rollno = 0;
        //    this.name = "";
        //    this.age = 0;
        //    this.standard = 0;
        //}

        // parameterized constructor
        public Student(int rollno, string name, int age, int standard)
        {
            this.rollno = rollno;
            this.name = name;
            this.age = age;
            this.standard = standard;
        }

        // method
        public void setStudent(int r, string n, int a, int s)
        {
            this.rollno = r;
            this.name = n;
            this.age = a;
            this.standard = s;
        }

        public void getStudentDetails()
        {
            Console.WriteLine($"The roll no is {this.rollno}.");
            Console.WriteLine($"The name is {this.name}.");
            Console.WriteLine($"The age is {this.age}.");
            Console.WriteLine($"The standard is {this.standard}.");
        }

        // access specifiers
        // private    --> only within class
        // public     --> anywhere (main, class, child)
        // protected  --> class and its children


    }
}

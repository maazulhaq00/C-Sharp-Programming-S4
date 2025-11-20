using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOPs
{
    internal class Inheritance
    {
        public static void Run()
        {
            Person p1 = new Person("Ali", 34);
            p1.getDetails();

            Teacher t1 = new Teacher("Maaz", 16, "C# Programming");
            //t1.getDetails();
            t1.getTeachersDetail();
        }
    }

    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void getDetails()
        {
            Console.WriteLine($"My name is {this.name}. I am {this.age} years old.");
        }
    }

    class Teacher : Person
    {
        public string subject;

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            this.subject = subject;
        }

        public void getTeachersDetail()
        {
            this.getDetails();
            Console.WriteLine($"I teach {this.subject} to my students.");
        }
    }
}

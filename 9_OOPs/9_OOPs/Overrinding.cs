using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _9_OOPs
{
    internal class Overrinding
    {
        public static void Run()
        {
            Cat c1 = new Cat("Leo");

            c1.Speaks();

            Dog d1 = new Dog("Tom");

            d1.Speaks();
        }
    }

    class Animal
    {
        protected string name;
        
        public Animal(string name)
        {
            this.name = name;
        }

        public virtual void Speaks()
        {
            Console.WriteLine($"{this.name} Speaks");
        }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {

        }

        public override void Speaks()
        {
            Console.WriteLine($"{this.name} Mewos");

        }

    }
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {

        }

        public override void Speaks()
        {
            Console.WriteLine($"{this.name} Barks");

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Animal
    {
        public string name;
        public int age;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine($"{name} is a Animal");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes Sound.");

        }

    }



    class Dog : Animal {

        public Dog(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{name} is a Cat makes Meow Sound.");
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{name} is a Cat makes Meow Sound.");
        }
    }

    class Bird: Animal
    {
        public Bird(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{name} is a Cat makes Chirping Sound.");
        }
    }
}

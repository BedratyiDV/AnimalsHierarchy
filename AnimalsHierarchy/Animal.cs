using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsHierarchy
{
    public class Animal
    {
        protected string ?Name { get; set; }
        protected int Age { get; set; }

        public Animal(string? name, int age)
        {
            Name = name;
            Age = age;
        }
        public Animal()
        {
            
        }

        public virtual void Move() 

        { 
            Console.WriteLine("The animal is moving");
        }
        public virtual void Speak()

        {
            Console.WriteLine("The animal is speaking");
        }
    }
}

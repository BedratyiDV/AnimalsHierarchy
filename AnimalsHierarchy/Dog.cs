using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsHierarchy
{
    internal class Dog: Mammal
    {
        protected string? Breed;
        protected int Weight;

        internal Dog(string name, int age, string predatorOrHerbivore) : base(name, age, predatorOrHerbivore)
        {
        }
        internal Dog(string predatorOrHerbivore) 
        {
        }
    }
}

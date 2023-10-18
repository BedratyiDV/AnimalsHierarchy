using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsHierarchy
{
    internal class Cat: Mammal
    {
        internal string? Breed;
        internal int Weight;

        internal Cat(string name, int age, string predatorOrHerbivore) : base(name, age, predatorOrHerbivore)
        {
        }
        internal Cat(string breed, int weight)
        {
            Breed = breed;
            Weight = weight;
        }
        protected string? breed
        {
            get => Breed;
            set => Breed = value is not null ? value : "Not defined";
        }
        protected int weight
        {
            get => Weight;
            set => Weight = value > 0 ? value : 0;
        }
    }
}

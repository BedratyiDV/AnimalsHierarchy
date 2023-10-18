using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsHierarchy
{
    internal class Mammal: Animal
    {
        internal string? PredatorOrHerbivore;

        internal Mammal(string name, int age): base(name, age) 
        {
            
        }
        internal Mammal(string name, int age, string predatorOrHerbivore) : base(name, age)
        {
             PredatorOrHerbivore = predatorOrHerbivore;
        }
        internal Mammal()
        {
        }
        protected string? predatorOrHerbivore
        {
            get => PredatorOrHerbivore;
            set => PredatorOrHerbivore = value is not null ? value : "Not defined";
        }
        public override void Move()

        {
            Console.WriteLine("The Mammal is moving");
        }
        public override void Speak()

        {
            Console.WriteLine("The Mammal is speaking");
        }
    }
}

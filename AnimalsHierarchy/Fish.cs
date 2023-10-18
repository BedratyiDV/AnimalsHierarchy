using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsHierarchy
{
    internal class Fish: Animal
    {
        public sealed override void Speak()
        {
            Console.WriteLine("Fish don't speak");
        }
        public override void Move()
        {
            Console.WriteLine("The Fish is swimming");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsHierarchy
{ 
    public class Bird : Animal
    {
        public override void Speak()
        { 
            Console.WriteLine("The Bird is singing "); 
        }
        public override void Move()
        {
            Console.WriteLine("The Bird is flying ");
        }
    }
}
     
        




namespace AnimalsHierarchy
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Animal animal1 = new("Lion", 3);

            Mammal mammal1 = new Mammal("Fox", 1, "Predator");

            animal1.Speak();
            animal1.Move();

            mammal1.Speak();
            mammal1.Move();
            Console.WriteLine($"Mammal1 predatot or herbivore {mammal1.PredatorOrHerbivore}");
            mammal1.PredatorOrHerbivore = "Herbivore";
            Console.WriteLine($"Mammal1 predatot or herbivore {mammal1.PredatorOrHerbivore}");

            Cat cat1 = new("Rex", 3, "Predator");
            Cat cat2 = new("Sfinx", 4);
            Animal animal2 = new Cat("Scotish", 2);
            Console.WriteLine($"Cat2 breed {cat2.Breed}");
            cat2.Breed = "British";
            Console.WriteLine($"Cat2 breed {cat2.Breed}");
            animal2.Speak();
            animal2.Move();

        }
    }
}
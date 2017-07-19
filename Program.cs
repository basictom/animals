using System;


namespace animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🐿");
            
            var neverneverland = new Forest("Never Never Land", "Far Far Away");
            var secondForrest = new Forest("Another Forest", "The other direction");

            var deer = new Animal{
                Name = "Deer",
                NumberOfLegs = 4,
                Fur = "Coarse Hair"
            };

            var moose = new Animal{
                Name = "Deer",
                NumberOfLegs = 4,
                Fur = "Brown Hair"
            };

            if(deer.Name == moose.Name)
            {
                Console.WriteLine("They are equal");
            } 
            else 
            {
                Console.WriteLine("They are not true");
            }

            var elk = new Animal{
                Name = "Elk",
                NumberOfLegs = 4,
                Fur = "Majestic F*ing Hair"
            };

            var squirrel = new Squirrel("Mr. Fuzzy Nuts", "Gray and Patchy"){
                TailLength = 17;
            };
            var bear = new Bear("Yogi", "Blue")
            {
                TailLength = 0;
            }
            var spider = new Animal{
                Name = "Spider",
                NumberOfLegs = 8,
                Fur = "Exoskelton"
            };
            var rabbit = new Animal{
                Name = "Wabbit",
                NumberOfLegs = 4,
                Fur = "Soft Fur"
            };

            neverneverland.AddAnimal(deer);
            neverneverland.AddAnimal(moose);
            neverneverland.AddAnimal(elk);

            secondForrest.AddAnimal(squirrel);
            secondForrest.AddAnimal(spider);
            secondForrest.AddAnimal(rabbit);

            // Console.WriteLine()
            neverneverland.ListAnimals();
            secondForrest.ListAnimals();

        }
    }
}

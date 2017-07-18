using System;
using System.Collections.Generic;

namespace animal
{
    public class Forest
    {
        public string Name { get; }
        public string Location { get; }
        List<Animal> Animals { get; set; } = new List<Animal>();

        public void AddAnimal(Animal furry)
        {
            Animals.Add(furry);
        }
        public Forest(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public void ListAnimals()
        {
            foreach (var fuzzy in Animals)
            {
                Console.WriteLine($"Silly {fuzzy.Name} frolics in {Location}. It has {fuzzy.NumberOfLegs} legs and it's stupid fur is {fuzzy.Fur}");
            }
        }
    }
}
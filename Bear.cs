namespace animal.Animals
{
    public class Bear : Animal, IFurryAnimal, IWalkingAnimal
    {
        public int NumberOfLegs => 4;
        public string TypeOfFur { get; set; }

        public int TailLength { get; set; }

        public Bear(string Name, string TypeOfFur)
        {
            Name = Name;
            TypeOfFur = Fur;
        }
        void Walk(int paceCount)
        {
            Console.WriteLine($"{Name} took {paceCount} strolls with his {PicnicBasketAmount} picnis baskets");
        }
    }

    

    internal interface IWalkingAnimal
    {
    }

    internal interface IFurryAnimal
    {
    }
}
namespace animal.Animals
{
    public class Squirrel : Animal
    {
        public int NumberOfLegs => 4;
        public string TypeOfFur { get; set; }

        public int TailLength { get; set; }

        public Squirrel(string Name, string TypeOfFur)
        {
            Name = Name;
            TypeOfFur = Fur;
        }
    }
}
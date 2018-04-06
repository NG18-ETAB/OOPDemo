namespace OOPDemo
{
    internal class Cat : Mammal
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        public Cat(string name, int weight) : this(name, weight, "unknown")
        {
        }

        public Cat(string name, int weight, string breed) :base(weight)
        {
            Name = name;
            Breed = breed;
        }

        public override string ToString()
        {
            return base.ToString() + $", {Name} ({Breed})";
        }

        public override void Talk()
        {
            System.Console.WriteLine("meow");
        }
    }
}
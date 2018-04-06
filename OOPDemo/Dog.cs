namespace OOPDemo
{
    internal class Dog: Mammal
    {
      
        public Dog(int weight) : base(weight)
        {
        }

        public new void Talk() {
            System.Console.WriteLine("woof");
        }
    }
}
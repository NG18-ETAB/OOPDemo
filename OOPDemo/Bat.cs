namespace OOPDemo
{
    internal class Bat : Mammal, IFlying
    {
        public Bat(int weight) : base(weight)
        {
        }

        public bool IsFlying { get; private set; }

        public void Fly()
        {
            IsFlying = true;
        }

        public void Land()
        {
            IsFlying = false;
        }

        public override void Talk()
        {
            System.Console.WriteLine("squeech");
        }

        public override string ToString()
        {
            return base.ToString() + " " + (IsFlying ? "Flying" : "Not flying");
        }
    } 
}
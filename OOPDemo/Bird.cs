namespace OOPDemo
{
    internal class Bird : Animal, IFlying
    {
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
            System.Console.WriteLine("tweet");
        }

        public override string ToString()
        {
            return base.ToString() + " " +  (IsFlying ? "Flying" : "Not flying");
        }
    }
}
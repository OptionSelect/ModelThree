namespace ModelThree
{
    class MessengerBag : Backpack
    {
        public bool hasShoulderStrap { get; set; } = true;

        public MessengerBag(string x, string y, string z) : base(x, y, z)
        {
        }
        public override string ToString()
        {
            return $"My messenger contains: {Laptop}, {Umbrella}, and {WaterBottle}. Does it have a shoulder strap? {hasShoulderStrap}";
        }
    }
}
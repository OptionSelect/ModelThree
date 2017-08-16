namespace ModelThree
{
    class FannyPack : Backpack
    {
        public bool hasWaistband { get; set; } = true;
        public FannyPack(string x, string y, string z) : base(x, y, z)
        {
        }
        public override string ToString()
        {
            return $"My fannypack contains: {Laptop}, {Umbrella}, and {WaterBottle}. Does it have a waistband? {hasWaistband}";
        }
    }
}
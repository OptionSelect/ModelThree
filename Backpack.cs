using System;

namespace ModelThree
{
    public class Backpack
    {
        //Properties
        public string Laptop { get; set; }
        public string WaterBottle { get; set; }
        public string Umbrella { get; set; }

        public override string ToString()
        {
            return $"My pack contains: {Laptop}, {Umbrella}, and {WaterBottle}.";
        }

        //Constructor
        public Backpack(string laptop, string waterbottle, string umbrella)
        {
            Laptop = laptop;
            WaterBottle = waterbottle;
            Umbrella = umbrella;
        }
    }
}



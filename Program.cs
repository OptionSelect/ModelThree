using System;

namespace ModelThree
{
    class Program
    {
        public class backPack
        {
            //Properties
            public string Laptop { get; set; }
            public string WaterBottle { get; set; }
            public string Umbrella { get; set; }

            public override string ToString()
            {
                return $"My backpack contains: {Laptop}, {Umbrella}, and {WaterBottle}.";
            }

            //Constructor
            public backPack(string laptop, string waterbottle, string umbrella)
            {
                Console.WriteLine("Creating a new Pack.");
                Laptop = laptop;
                WaterBottle = waterbottle;
                Umbrella = umbrella;
            }
        }

        public class Arsenal
        {
            public string Striker { get; set; }
            public string Manager { get; set; }
            public string FavoritePlayer { get; set; }

            public override string ToString()
            {
                return $"My favorite team is Arsenal. The manager is {Manager}. Their striker is {Striker}. My favorite player is {FavoritePlayer}.";
            }
            public Arsenal(string striker, string manager, string favoritePlayer)
            {
                Console.WriteLine("Displaying Arsenal.");
                Striker = striker;
                Manager = manager;
                FavoritePlayer = favoritePlayer;
            }
        }

        public class DnDChar
        {
            //3
            public string Name { get; set; }
            public string Weapon { get; set; }
            public string BeardColor { get; set; }

            public override string ToString()
            {
                return $"My character's name is {Name} and they use a {Weapon}. Their beard color is {BeardColor}.";
            }
            public DnDChar(string name, string weapon, string beardColor)
            {
                Console.WriteLine("Creating a new DnD Character.");
                Name = name;
                Weapon = weapon;
                BeardColor = beardColor;
            }
        }
        static void Main(string[] args)
        {
            var blastBeard = new DnDChar("Blastbeard", "Greatsword", "Black");
            var team = new Arsenal("Alexandre Lacazette", "Arsene Wenger", "Olivier Giroud");
            var backpackerino = new backPack("Mac", "Futurespace", "Small Green Umbrella");

            Console.WriteLine(blastBeard);
            Console.WriteLine(team);
            Console.WriteLine(backpackerino);
        }
    }
}

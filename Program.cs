using System;

namespace ModelThree
{
    class Program
    {
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
            // var blastBeard = new DnDChar("Blastbeard", "Greatsword", "Black");
            // var team = new Arsenal("Alexandre Lacazette", "Arsene Wenger", "Olivier Giroud");
            var backpackerino = new Backpack("Mac", "Futurespace", "Small Green Umbrella");
            var fanny = new FannyPack("Netbook", "Mini", "Super small");
            var messy = new MessengerBag("Linux Machine", "Gallon Jug", "Full Poncho");

            // Console.WriteLine(blastBeard);
            // Console.WriteLine(team);
            Console.WriteLine(backpackerino);
            Console.WriteLine(fanny);
            Console.WriteLine(messy);
        }
    }
}

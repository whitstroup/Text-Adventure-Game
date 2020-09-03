using System;

namespace Pirate
{
    class Program
    {



        static void Main(string[] args)
        {
            var pirate = new Pirate();
            pirate.TEST = "Black Tooth";
            var game = new Game();


            PirateAdventure pirateAdventure = new PirateAdventure();


            pirateAdventure.name = "Bob";

            pirateAdventure.Name = "Joe";

            Console.WriteLine(pirateAdventure.name);
            Console.WriteLine(pirateAdventure.Name);






        }
    }
}

using System;
namespace Pirate
{
    public class Pirate 
    {
        public Pirate()
        {
            var game = new Game();
            Console.WriteLine("ARRRR Welcome YEE to my Pirate Adventure!");
            Console.WriteLine("");
            Name = game.GetUserResponse("AAR what is your PIRATE name?");
            Console.Clear();
            LastName = game.GetUserResponse("And what is yee Pirate last name?");
            Console.Clear();
            string FullPirateName = (Name + " " + LastName);

            Console.WriteLine($"Welcome {FullPirateName}, To my pirate adventure!");
        }

        public string FullPirateName { get; set; }
        private int Health = 5;

        public string Name { get; set; }
        
        public string LastName { get; set; }

        public int score { get; set; }

        public int GetHealth()
        {
            return Health;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public bool GameOver()
        {
            return Health == 0;
        }

        public void ResetHealth()
        {
            Health = 5;
        }


        public string NewPirateName()
        {
            return $"{Name} {LastName}";
        }

       
    }
}

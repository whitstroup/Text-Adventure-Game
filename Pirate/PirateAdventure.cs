using System;
using System.Threading;

namespace Pirate
{
    public class PirateAdventure : Game
    {
        public PirateAdventure()
        {
            health = 5;
        }
        public string name;
        public string Name { get; set; }
        public void runPirateGame()
        {
            MainMenu();
       
            while (health > 0)
            {

            Console.WriteLine("ARRRR Welcome YEE to my Pirate Adventure!");
            Console.WriteLine("");
            Name = GetUserResponse("AAR what is your PIRATE name?");
            Console.Clear();
            LastName = GetUserResponse("And what is yee Pirate last name?");
            Console.Clear();
            string newpiratename = (Name + " " + LastName);

            Console.WriteLine($"Welcome {newpiratename}, To my pirate adventure!");

            string answer;

            do

            {

                answer = GetUserResponse("Would you like to go on an adventure? Enter yes or no");
                Console.Clear();

                if (answer == "no")
                {

                    Console.WriteLine("That's an unnaceptable answer me matey!");
                        LoseLife();
                }

                else if (answer == "yes")

                {
                    Console.WriteLine("PEERFECT LET'S BEGIN!!");
                        break;
                }
            }
            while (health > 0);



            Console.WriteLine("I kneeeew yeee had it in ya!");

            string answertwo;

                while(health > 0)
                {
                answertwo = GetUserResponse("Would you like to search for buried treasure? Yes or No?");
                Console.Clear();

                if (answertwo == "no")
                {

                    Console.WriteLine("Ya want to stay at home and fiddle yer thumbs?!");
                        LoseLife();
                }
                else if (answertwo == "yes")
                {
                        Console.WriteLine("Buried treasure it is!");
                            break;
                }

            } 


            
            while (health > 0)
            {
                    Console.WriteLine("Your an adeventure lubber like I!");

                    string answerthree;

                    Console.WriteLine("AAARR I got two adventures on my horizon. Would you like to begin your journey for treasure?");
                Console.WriteLine("Or would yee rather go whale hunting for supplies first?");
                answerthree = GetUserResponse("Reply: whale hunting: or: begin journey");
                Console.Clear();

                if (answerthree == "whale hunting")
                {
                    Console.WriteLine("Excellent choice! Yee are well on your way to be a pirate!");
                        break;
                }
                else if (answerthree == "begin journey")
                {
                    Console.WriteLine("Try again! We don't want to starve on our journey!");
                        LoseLife();
                }
                else
                {
                    Console.WriteLine("speak up youngster! Do you not speech pirate??");
                        LoseLife();
                }
            }



                
            while (health > 0)
            {

                    Console.WriteLine($"Alrighty then {newpiratename}, I got another test to see if you are truly ready to set sail.");

                    string answerfour;

                    Console.WriteLine("Yee got 4 measly choices so listen carefully! Choose yer letter!");

                answerfour = GetUserResponse("Which direction is true pirate North? is it A.North on me compass? B.Wherever my captain says it is? C.The way the wind blows? or D.The fastest way to danger?");
                Console.Clear();
                if (answerfour == "A")
                {
                    Console.WriteLine("WRONG! You failed matey!Try again.");
                    LoseLife();
                }

                else if (answerfour == "B")
                {
                    Console.WriteLine("What's wrong with you my friend!? Try again!");
                    LoseLife();
                }
                else if (answerfour == "C")
                {
                    Console.WriteLine("THAT'S the SPIRIT!!");
                        break;
                }

                else if (answerfour == "D")
                {
                    Console.WriteLine("I guess I was wrong about you, young whipper snapper!");
                    LoseLife();
                }
                else
                { Console.WriteLine("That didn't sound like pirate speech to me!"); LoseLife(); }


            }



                
                while (health > 0 )
            {

            Console.WriteLine($" AAAAARRR Ya did it congrats {newpiratename}!!");



            Console.WriteLine($"So far I got alot of faith in thee {newpiratename}, this is your final test to see if you are truly ready to set sail.");

            string answerfive;
                Console.WriteLine("Yee got 4 measly choices so listen carefully! Choose yer letter!");

                answerfive = GetUserResponse("What be your favorite kind of treasure? is it A.GOLD!!!? B.Whatever calls to you? C.Finding happiness and joy? or D.All the Above?");
                Console.Clear();
                if (answerfive == "A")
                {
                    Console.WriteLine("True but not the answer I was looking for!");
                    LoseLife();
                }

                else if (answerfive == "B")
                {
                    Console.WriteLine("True but not the answer I was looking for!");
                    LoseLife();
                }
                else if (answerfive == "C")
                {
                    Console.WriteLine("True but not the answer I was looking for!");
                    LoseLife();
                }

                else if (answerfive == "D")
                {
                    Console.WriteLine("You are a true treasure lubber!");

                        
                }
                else
                { Console.WriteLine("That didn't sound like pirate speech to me!"); LoseLife(); }


            }


            Console.Clear();
            if (health == 0)
            {
                Console.WriteLine("Game oveeeeer");
                Console.WriteLine("If ya want to try again say: yes!");
                if (Console.ReadLine() == "yes" || Console.ReadLine() == "Yes")
                {
                    health = 5;
                    runPirateGame();
                    
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
            }
            else
            Console.WriteLine($" {Name} {LastName}, you are a lengendary pirate truly you are. AAAARRRR!!");
            }
           

               
            
        }
    }
}

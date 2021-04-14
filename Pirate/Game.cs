using System;
using System.Threading;

namespace Pirate
{
    public class Game
    {
        public Game()
        {
        }
       
        
       

        public  string GetUserResponse(string question)
        {
            Console.WriteLine(question);
            string userResponse = Console.ReadLine();
            while (userResponse == "")
            {
                Console.WriteLine("Please enter yee a response.");
                Console.WriteLine(question);
                userResponse = Console.ReadLine();
            }
            return userResponse;
        }


        protected void LoseLife()
        {
            
        }

        protected void MainMenu()
        {
            Console.WriteLine(@"                                                                        
  ,_    .  ,_  __,  -/- _     __,   __/_,     _   ,__,  -/-      ,_   _ 
 _/_)__/__/ (_(_/(__/__(/_   (_/(__(_/(_(_/__(/__/ / (__/__(_/__/ (__(/_
 /                                                                      
/                                                                       
                                                                                   ");
            Thread.Sleep(2000);
            Console.Clear();
        }


    }
}
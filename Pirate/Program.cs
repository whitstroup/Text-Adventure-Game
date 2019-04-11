using System;

namespace Pirate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRRR Welcome YEE to my Pirate Adventure!");
            Console.WriteLine("");
            Console.WriteLine("Do ya have what it takes to be a pirate?!?!?");
            Console.WriteLine("Enter yes or no");
            string answer = Console.ReadLine();

           

            if (answer == "yes")
            {
                Console.WriteLine("I kneeeew yeee had it in ya!");
                Console.WriteLine("Would ya like to go on a treasure adventure with me?");
                Console.WriteLine("yes or no");
                string answertwo = Console.ReadLine();

                if (answertwo == "yes")
                {
                    Console.WriteLine("Your an adeventure lubber like I!");
                    Console.WriteLine("AAARR I got two adventures on my horizon. Would you like to search for buried treasure?");
                    Console.WriteLine("Or would yee rather go whale hunting?");
                    Console.WriteLine("Enter 1 for buried treasure. Enter 2 for whale hunting.");



                        
                    {
                        Console.WriteLine("TREASURE HUNTING!");
                    }
                    
                   

                      
                    
                }
            }

            else if (answer == "no")
            {
                Console.WriteLine("Have a good day yee LANDLUBBER!");
            }
            else
            {
                Console.WriteLine("You don't speak pirate do ya? Try again");
            }



        }
    }
}

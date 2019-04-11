using System;

namespace Pirate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRRR Welcome YEE my Pirate Adventure!");
            Console.WriteLine("");
            Console.WriteLine("Do ya have what it takes to be a pirate?!?!?");
            Console.WriteLine("Enter yes or no");
            string answer = Console.ReadLine();

           

            if (answer == "yes")
            {
                Console.WriteLine("I kneeeew yeee had it in ya!");
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

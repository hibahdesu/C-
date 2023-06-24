using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while (playAgain == true)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " and " + max + ":");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!");
                    } 
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low!");
                    }
                    else
                    {
                        Console.WriteLine(guess + "");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You Win!");
                Console.WriteLine("Guesses: " + guesses);
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y" || response == "YES")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
                

            }

            
            Console.WriteLine("Would you like to play again?");

            Console.ReadKey();
        }
    }
}

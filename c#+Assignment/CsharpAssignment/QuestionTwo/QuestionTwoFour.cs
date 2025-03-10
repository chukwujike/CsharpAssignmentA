using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment.QuestionTwo
{
    public class QuestionTwoFive
    {
        public static void QuestionTwoFiveExe()
        {
            // Create a new random number generator
            Random random = new Random();

            // Generate a random secret number between 1-10.
            int secretNumber = random.Next(1, 11);

            int attempts = 4;

            Console.WriteLine("Guess the number between 1 and 10. You have 4 attempts.");

            // Loop four times
            for (int i = 0; i < attempts; i++)
            {
                Console.Write("Enter your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }

            Console.WriteLine("You lost. The correct number was " + secretNumber);

        }
    }
}
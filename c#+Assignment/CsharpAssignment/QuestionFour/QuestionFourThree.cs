using System; 
using System.Collections.Generic;

namespace CsharpAssignment.QuestionFour
{
    public class QuestionFourThree
    {
        
        public static void QuestionFourThreeExe()
        {
            // Prompt the user to enter a time in 24-hour format.
            Console.Write("Enter a time in 24-hour format (HH:mm): ");
            string input = Console.ReadLine();


            // Validate the input.  Exit if null or empty.
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            // Split the input string into hours and minutes parts based on the colon delimiter.
            string[] parts = input.Split(':');

            // Check if the input has two parts (hours and minutes) and if they can be parsed to integers.
            // Also, validate the range of hours (0-23) and minutes (0-59).
            if (parts.Length != 2 ||
                !int.TryParse(parts[0], out int hours) ||
                !int.TryParse(parts[1], out int minutes) ||
                hours < 0 || hours > 23 ||
                minutes < 0 || minutes > 59)
            {
                Console.WriteLine("Invalid Time");
            }
            else
            {
                Console.WriteLine("Ok");
            }

        }
    }
}
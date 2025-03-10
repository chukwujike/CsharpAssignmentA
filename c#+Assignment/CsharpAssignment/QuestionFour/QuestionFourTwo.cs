using System; 
using System.Collections.Generic; 

namespace CsharpAssignment.QuestionFour
{
    public class QuestionFourTwo
    {
        public static void QuestionFourTwoExe()
        {
            // Prompt the user to enter numbers separated by hyphens.
            Console.Write("Enter a few numbers separated by a hyphen: ");
            string input = Console.ReadLine();

            // If the input is null, empty, or contains only whitespace, exit the method.
            if (string.IsNullOrWhiteSpace(input))
                return;

            // Split the input string into an array of strings based on the hyphen delimiter.
            string[] parts = input.Split('-');
            // Use a HashSet to efficiently store and check for duplicate numbers.
            HashSet<int> numbers = new HashSet<int>();

            // Iterate through each part of the split input.
            foreach (string part in parts)
            {
                if (int.TryParse(part.Trim(), out int number))
                {
                    if (!numbers.Add(number))
                    {
                        Console.WriteLine("Duplicate");
                        return;
                    }
                }
                else
                {
                    // If the input part is not a valid integer, print an error message and exit.
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                    return;
                }
            }

        }
    }
}
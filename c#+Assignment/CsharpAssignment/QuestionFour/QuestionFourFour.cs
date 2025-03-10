using System;
using System.Linq;

namespace CsharpAssignment.QuestionFour
{
    public class QuestionFourFour
    {
        public static void QuestionFourFourExe()
        {
            Console.Write("Enter words separated by spaces: ");
            // Read the user's input and remove leading/trailing whitespace.
            string input = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            // Split the input string into an array of words, removing empty entries.
            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Iterate through each word in the array.
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }

            // Join the modified words together without any separator to form the PascalCase string.
            string pascalCase = string.Join("", words);
            Console.WriteLine(pascalCase);

        }
    }
}
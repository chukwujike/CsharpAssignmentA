using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment.QuestionFour
{
    public class QuestionFourFive
    {
        public static void QuestionFourFiveExe()
        {
            Console.Write("Enter an English word: ");
            string input = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            
            // Call the CountVowels method to count the vowels in the input (correct)
            int vowelCount = CountVowels(input);
            Console.WriteLine("Number of vowels: " + vowelCount);
        }
    
        static int CountVowels(string word)
        {
            // Initialize a counter for vowels (correct)
            int count = 0;

            // Define a string containing all vowels (correct)
            string vowels = "aeiouAEIOU";
            
            // Iterate through each character in the input word (correct)
            foreach (char c in word)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            return count;

        }
    }
}
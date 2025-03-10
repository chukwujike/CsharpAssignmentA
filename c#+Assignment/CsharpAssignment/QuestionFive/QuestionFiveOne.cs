using System;
using System.IO;

namespace CsharpAssignment.QuestionFive
{
    public class QuestionFiveOne
    {
        public static void QuestionFiveOneExe()
        {
            string filePath = "prd.txt"; // Change this to your file path

            // Check if the file exists before trying to read it.
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            // Read the entire file content into a string.
            string text = File.ReadAllText(filePath);

            // Call the CountWords method to get the word count.
            int wordCount = CountWords(text);

            Console.WriteLine("Number of words: " + wordCount);
        }

         // Method to count words in a given string.
        static int CountWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;
            // Split the string into words based on whitespace characters (space, newline, carriage return, tab).
            // StringSplitOptions.RemoveEmptyEntries removes empty entries from the array, 
            // which would occur if there are multiple spaces together.
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }


    }
}
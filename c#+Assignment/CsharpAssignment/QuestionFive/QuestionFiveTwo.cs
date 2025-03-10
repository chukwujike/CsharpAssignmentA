using System;
using System.IO;
using System.Linq;

namespace CsharpAssignment.QuestionFive
{
    public class QuestionFiveTwo
    {
        public static void QuestionFiveTwoExe()
        {
            string filePath = "prd.txt"; // Change this to your file path

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            // Read the entire file content, split it into words, find the longest word, and handle the case where the file is empty.
            string longestWord = File.ReadAllText(filePath)
                                    .Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', ';', '!', '?', '/' }, StringSplitOptions.RemoveEmptyEntries)
                                    .OrderByDescending(w => w.Length)
                                    .FirstOrDefault() ?? "";

            Console.WriteLine("Longest word: " + longestWord);

        }

    }
}
using System; // Added missing using statement for Console and other base classes
using System.Collections.Generic; // Added missing using statement for List
using System.Linq;

namespace CsharpAssignment.QuestionFour
{
    public class QuestionFourOne
    {
        public static void QuestionFourOneExe()
        {
            Console.Write("Enter a few numbers separated by a hyphen: ");
            string input = Console.ReadLine();

            // Convert input into a list of numbers
            string[] parts = input.Split('-');
            List<int> numbers = new List<int>();

            // Iterate through each part of the split string
            foreach (string part in parts)
            {
                // Attempt to convert each part to an integer
                if (int.TryParse(part.Trim(), out int number)) // Trim removes whitespace around the number string
                {
                    numbers.Add(number);
                }
                else
                {
                    // If the conversion fails, display an error message and exit the method
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                    return;
                }
            }

            // Check if numbers are consecutive
            bool isConsecutive = true;

            // Iterate through the list, comparing each number with the previous one
            for (int i = 1; i < numbers.Count; i++)
            {
                // Check if the absolute difference between the current number and the previous number is not equal to 1
                if (Math.Abs(numbers[i] - numbers[i - 1]) != 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");

        }
    }
}
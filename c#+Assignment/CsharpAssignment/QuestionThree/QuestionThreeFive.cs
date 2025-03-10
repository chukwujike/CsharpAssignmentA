using System; // Add this line to include the System namespace for Console, String, etc.
using System.Collections.Generic; // Add this line for using List<T>
using System.Linq; // Add this line for using LINQ methods like OrderBy, Take, Select

namespace CsharpAssignment.QuestionThree

{
    public class QuestionThreeFive
    {
        public static void QuestionThreeFiveExe()
        {   

            // Continuously prompt the user for input until a valid list of numbers is entered.
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                string input = Console.ReadLine();

                List<int> numbers;
                try
                {
                    // 1. Split the input string by commas.
                    // 2. Trim whitespace from each part.
                    // 3. Convert each part to an integer.
                    // 4. Convert the result to a List<int>.
                    numbers = input.Split(',').Select(n => Convert.ToInt32(n.Trim())).ToList();
                }
                catch
                {
                    Console.WriteLine("Invalid List. Please enter valid numbers.");
                    continue;
                }

                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                    continue;
                }

                // Find the three smallest numbers.
                var smallestNumbers = numbers.OrderBy(n => n).Take(3);

                // Print the three smallest numbers to the console.
                Console.WriteLine("The three smallest numbers are: " + string.Join(", ", smallestNumbers));
                break;

            }
        }
    }
}
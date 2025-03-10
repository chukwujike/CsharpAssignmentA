using System; // Add this line to include the System namespace for Console, string, etc.
using System.Collections.Generic; // Required for HashSet<T>

namespace CsharpAssignment.QuestionThree
{
    public class QuestionThreeFour
    {
        public static void QuestionThreeFourExe()
        {
            // Create a HashSet to store unique integer values.
            // HashSets automatically handle duplicate removal.
            HashSet<int> uniqueNumbers = new HashSet<int>();

            // Enter a loop that continues until the user enters "Quit."
            while (true)
            {
                Console.Write("Enter a number or type 'Quit' to exit: ");
                string input = Console.ReadLine();

                // Exit the loop if the input is "quit."
                if (input.ToLower() == "quit")
                    break;

                // Attempt to parse the user's input as an integer.
                // int.TryParse returns true if the parse is successful and stores the parsed value in 'number.'
                if (int.TryParse(input, out int number))
                    uniqueNumbers.Add(number);
            }

            // Print the unique numbers entered, separated by commas.
            Console.WriteLine("Unique numbers entered: " + string.Join(", ", uniqueNumbers));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment.QuestionTwo
{
    public class QuestionTwoTwo
    {
        public static void QuestionTwoTwoExe()
        {
            // Initialize a variable to store the sum of numbers.
            int sum = 0;

            while (true)
            {
                Console.Write("Enter a number or type 'ok' to exit: ");
                string input = Console.ReadLine();

                // Check if the user entered 'ok' (case-insensitive).
                if (input.ToLower() == "ok")
                    break;


                // If the input is a valid integer, add it to the sum
                if (int.TryParse(input, out int number))
                    sum += number;
            }

            Console.WriteLine($"Total sum of entered numbers: {sum}");

        }
    }
}
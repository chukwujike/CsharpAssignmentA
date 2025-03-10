using System;



namespace CsharpAssignment.QuestionOne
{
    public class assignmentOneOne
    {
        public static void assignmentOneOneExe()
        {
            Console.Write("Enter a number between 1 and 10: ");

            string input = Console.ReadLine();


            // Tries to parse the input string to an integer.  
            // The 'out int number' declares and initializes the 'number' variable if parsing is successful.
            // Also checks if the parsed number is within the valid range (1-10).

            if (int.TryParse(input, out int number) && number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

    }
}

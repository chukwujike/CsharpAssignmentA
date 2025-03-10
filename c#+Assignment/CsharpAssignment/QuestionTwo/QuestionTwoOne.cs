using System;

namespace NameCsharpAssignment.QuestionOne
{
    public class QuestionTwoOne
    {
        public static void QuestionTwoOneExe()
        {
            // Initialize a counter to store the count of numbers divisible by 3.
            int count = 0;

            // Loop through numbers from 1 to 100 (inclusive).
            for (int i = 1; i <= 100; i++)
            {
                // Check if the current number (i) is divisible by 3 (remainder is 0).
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine($"Count of numbers divisible by 3 between 1 and 100: {count}");

        }
    }
}
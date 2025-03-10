using System;
using System.Collections.Generic;
using System.Linq; // This using statement is not currently needed but might be if you use LINQ features later.
using System.Text; // This using statement is not currently needed.
using System.Threading.Tasks; // This using statement is not currently needed.

namespace CsharpAssignment.QuestionThree
{
    public class QuestionThreeOne
    {
        // Make the list static so it persists across calls to CountLikes().
        // This needs to be a *field* of the class, not declared inside a method.
        private static List<string> Names = new List<string>();

        public static string CountLikes()
        {
            Console.WriteLine("Enter a unique name (or press Enter to stop):");

            // Use ?. to handle potential null from ReadLine().
            string uniqueName = Console.ReadLine()?.Trim();

            // Check for null or empty input, signaling the end of input.
            if (string.IsNullOrEmpty(uniqueName))
            {
                if (Names.Count == 0)
                {
                    return "No one liked your post.";
                }
                else if (Names.Count == 1) // Use else if for clarity and efficiency.
                {
                    return $"{Names[0]} liked your post.";
                }
                else if (Names.Count == 2) // Use else if.
                {
                    return $"{Names[0]} and {Names[1]} liked your post.";
                }
                else // Simplified condition - no need for if (Names.Count >= 3).
                {
                    return $"{Names[0]}, {Names[1]} and {Names.Count - 2} others liked your post.";
                }
            }

            // Check for duplicate names.
            if (!Names.Contains(uniqueName))
            {
                Names.Add(uniqueName);
            }
            else
            {
                Console.WriteLine("This name has already liked the post. Enter a different name.");
            }

            // Recursive call – this could lead to stack overflow with enough entries. Consider a loop instead.
            return CountLikes();
        }

        // The questionThreeOneExe() method was incorrectly declared and is removed.  A proper entry point would be a Main method.

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment.QuestionThree
{
    public class QuestionThreeThree
    {
        public static void QuestionThreeThreeExe()
        {
            // Use a HashSet to store unique numbers efficiently
            HashSet<int> numbers = new HashSet<int>();

            // Loop until 5 unique numbers have been entered
            while (numbers.Count < 5)
            {
                Console.Write("Enter a unique number: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    // Attempt to add the number to the HashSet
                    // HashSet.Add() returns false if the element already exists

                    if (!numbers.Add(number))
                    {
                        Console.WriteLine("Number already entered. Try again.");
                        // Show the current entered numbers
                        Console.WriteLine("Entered numbers: " + string.Join(", ", numbers));
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            // Sort the entered numbers
            var sortedNumbers = numbers.OrderBy(n => n).ToList();

            // Display the sorted numbers
            Console.WriteLine("Sorted numbers: " + string.Join(", ", sortedNumbers));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignment.QuestionTwo
{
    public class QuestionTwoFive
    {
        public static void QuestionTwoFiveExe()
        {
            Console.Write("Enter a series of numbers separated by commas: ");
            string input = Console.ReadLine();


            // Split the input string by commas, trim whitespace from each element,
            // convert each element to an integer, and store them in an array
            int[] numbers = input.Split(',').Select(n => Convert.ToInt32(n.Trim())).ToArray();
            
            int maxNumber = numbers.Max();

            Console.WriteLine($"The maximum number is: {maxNumber}");

        }
    }
}